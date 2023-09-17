from TikTokLive import TikTokLiveClient
from TikTokLive.types.events import CommentEvent, ConnectEvent, GiftEvent, LikeEvent, FollowEvent, ShareEvent, JoinEvent, DisconnectEvent, LiveEndEvent, ViewerUpdateEvent, UnknownEvent
from TikTokLive.types.errors import FailedFetchRoomInfo, SignatureRateLimitReached, LiveNotFound
import asyncio
import asyncTikTokScraper
from traceback import print_exc
from collections import deque
import socketApi
import time
import sys
import keyauth
import ctypes
import key
import os
import traceback

pfpDownloadingQueue = []
pfpDownloaded = []
pfpDownloadFinished = []
# https://www.tiktok.com/@zh.xai
streamerName = sys.argv[1] # goofee_69 # reddit_officially # meastkill # __domix__ # zh.xai (always check)



# loop = asyncio.new_event_loop()
# asyncio.set_event_loop(loop)

lastInteractionTime = time.monotonic() # to check if script is still getting data else restarting

startedSuccessfully = False

# asyncio.new_event_loop().set_debug(True)

    
client: TikTokLiveClient = TikTokLiveClient(unique_id=f"@{streamerName}")


events = deque()

local_low_path = os.environ['APPDATA'].replace("Roaming", "LocalLow")
application_path = os.path.join(local_low_path, "InterTok", f"TikTok.{sys.argv[3]}", )
application_streaming_assets = os.path.join(application_path, f"Tiktok.{sys.argv[3]}_Data", "StreamingAssets")
status_file_path = os.path.join(application_path, "success")

async def downloadWrapper(username: str, url: str):
        if username not in pfpDownloaded:
            pfpDownloaded.append(username)
            downloading = True
            pfpDownloadingQueue.append(username)

            while(downloading):
                if pfpDownloadingQueue[0] == username:
                    


                    await (asyncTikTokScraper.downloadProfilePicture(url, username, application_streaming_assets))                   
                    downloading = False
                    pfpDownloadingQueue.pop(0)
                    pfpDownloadFinished.append(username)
                    
                else:

                    await asyncio.sleep(0.5)

lastViewerAmount = 0

async def getViewerCount():
    global startedSuccessfully
    while(True):

        lastInteractionDifference = time.monotonic() - lastInteractionTime

        if client.connected:
            if not startedSuccessfully:
                with open(status_file_path, "w") as f:
                      f.write("positive")
                startedSuccessfully = False
            if lastInteractionDifference > 60*10:
                print("last interaction was more than 10 minutes ago...\nRestarting script in 60 seconds")
                client.stop()
                print("stopped client")
                # print("Restarted script")
                # await asyncio.sleep(60)
                # await client.start()
        await asyncio.sleep(1)

@client.on("viewer_update")
async def on_connect(event: ViewerUpdateEvent):
   # print("stream has so many viewers: ", connectObject)
    global lastInteractionTime
    lastInteractionTime = time.monotonic()


@client.on("disconnect")
async def on_disconnect(event: DisconnectEvent):
    print("Disconnected, reconnecting in 2 minutes")
    await asyncio.sleep(120)
    await client.start()



@client.on("live_end")
async def on_connect(event: LiveEndEvent):
    print(f"Livestream ended :(")
    quit()


@client.on("connect")
async def on_connect(event: ConnectEvent):
        print("Connected to Room ID:", client.room_id)
        # print(await loop.create_task(client.retrieve_available_gifts()))
        global lastInteractionTime
        lastInteractionTime = time.monotonic()

@client.on("comment")
async def on_comment(event: CommentEvent):
    print(f"{event.user.unique_id} -> {event.comment}")

    events.append(dict(user=event.user.unique_id, event="comment", comment=event.comment))
    await downloadWrapper(event.user.unique_id, event.user.avatar.urls[1])
    global lastInteractionTime
    lastInteractionTime = time.monotonic()        

@client.on("gift")
async def on_gift(event: GiftEvent):
        # Streakable gift & streak is over
        if event.gift.streakable and not event.gift.streaking:
            print(f"{event.user.unique_id} sent {event.gift.count}x \"{event.gift.info.name}\"")
            events.append(dict( user=event.user.unique_id, event="gift", gift=event.gift.info.name, count=event.gift.count))
            with open("log.txt", "a") as file:
                file.write(f"{event.user.unique_id} sent {event.gift.count}x \"{event.gift.info.name}\"\n")

        # Non-streakable gift
        elif not event.gift.streakable:
            print(f"{event.user.unique_id} sent \"{event.gift.info.name}\"")
            events.append(dict( user=event.user.unique_id, event="gift", gift=event.gift.info.name, count=event.gift.count))
            with open("log.txt", "a") as file:
                file.write(f"{event.user.unique_id} sent {event.gift.count}x \"{event.gift.info.name}\"\n")

        
        await downloadWrapper(event.user.unique_id, event.user.avatar.urls[1])
        global lastInteractionTime
        lastInteractionTime = time.monotonic()

        

@client.on("like")
async def on_like(event: LikeEvent):
        print(f"@{event.user.unique_id} liked the stream {event.likes} times!")
        for queueEvent in events:

              if queueEvent["user"] == event.user.unique_id and queueEvent["event"] == "like":
                    queueEvent["count"] += event.likes
                    return 
        events.append(dict( user=event.user.unique_id, event="like", count=event.likes))
        await downloadWrapper(event.user.unique_id, event.user.avatar.urls[1])
        global lastInteractionTime
        lastInteractionTime = time.monotonic()

@client.on("follow")
async def on_follow(event: FollowEvent):
        print(f"@{event.user.unique_id} followed the streamer!")
        events.append(dict(user=event.user.unique_id, event="follow"))
        await downloadWrapper(event.user.unique_id, event.user.avatar.urls[1])
        global lastInteractionTime
        lastInteractionTime = time.monotonic()

@client.on("share")
async def on_share(event: ShareEvent):
        print(f"@{event.user.unique_id} shared the stream!")
        events.append(dict(user=event.user.unique_id, event="share"))
        await downloadWrapper(event.user.unique_id, event.user.avatar.urls[1])
        global lastInteractionTime
        lastInteractionTime = time.monotonic()
@client.on("error")
async def on_connect(error: Exception):
    # Handle the error
        print(f"An error ocurred in live api: {error}")
        print(traceback.format_exc())



@client.on("join")
async def on_join(event: JoinEvent):
    print(f"@{event.user.unique_id} joined the stream!")
    events.append(dict(user=event.user.unique_id, event="join"))
    await downloadWrapper(event.user.unique_id, event.user.avatar.urls[1])
    global lastInteractionTime
    lastInteractionTime = time.monotonic()


@client.on("unknown")
async def on_connect(event: UnknownEvent):
    print("Recieved unknown event: ", event)
    print(f"Event Type: {event.type}")
    print(f"Event Base64: {event.base64}")

async def stdoutFlusher():
    while True:
        sys.stdout.flush()
        await asyncio.sleep(5)

async def main():
    print(f"'{streamerName}'")
    try:
        await asyncio.gather(client.start(), socketApi.start_local_server(events=events, downloadedPfp=pfpDownloadFinished, statusPath=status_file_path), stdoutFlusher(), getViewerCount())
    except FailedFetchRoomInfo as e:
        #ctypes.windll.user32.MessageBoxW(None, "Could not connect to Livestream! Try using a VPN, your country could be blocked.", "InterTok Error", 0)
        
        with open(status_file_path, "w") as f:
            f.write("Could not connect to Livestream! Try using a VPN, your country could be blocked.")

        print(e)
        quit(-1)
    except SignatureRateLimitReached as e:
        #ctypes.windll.user32.MessageBoxW(None, f"You have been temporarly blocked from connecting to livestreams. Try again in {e.retry_after} seconds", "InterTok Error", 0)
        with open(status_file_path, "w") as f:
            f.write(f"Temporary livestream block. Try again in {e.retry_after} seconds.")
        print(e)
        quit(-1)
    except LiveNotFound as e:
        #ctypes.windll.user32.MessageBoxW(None, f"You have been temporarly blocked from connecting to livestreams. Try again in {e.retry_after} seconds", "InterTok Error", 0)
        with open(status_file_path, "w") as f:
            f.write(f"It seems you are yet not live.")
        print(e)
        quit(-1)
    except Exception as e: 
        with open(status_file_path, "w") as f:
            f.write("Unknown error occurred!.")
        
        print(e)
        print(type(e))
        quit(-1)
#argv: username, key
 


if __name__ == "__main__" and len(sys.argv) == 4:


    #success = key.checkLicense(sys.argv[2])
    if True:
        try:
            loop = asyncio.new_event_loop()  
            asyncio.set_event_loop(loop)
            loop.run_until_complete(main())
            loop.run_forever()
        except KeyboardInterrupt:
             quit()
    else:
        ctypes.windll.user32.MessageBoxW(None, "Key is not correct, try a different key or contact us over the InterTok Discord Server!", "InterTok Error", 0)      