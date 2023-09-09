import PySimpleGUI as sg
import webbrowser
import os
import key as keyauth
from bsod_generator import bsod_generator
import asyncio

DISC_LINK = "https://discord.com"
TIKTOK_LINK = "https://tiktok.com"





appdata =  os.path.abspath(os.path.join(os.getenv("LOCALAPPDATA"), os.pardir))
key_file_path = os.path.join(appdata, r"locallow\DefaultCompany\Tiktok_BallGame\key")
unity_path = os.path.join(appdata, r"local\InterTok")

GAMES = [i for i in os.listdir(unity_path)]



preUser = ""
preKey = ""
if os.path.exists(key_file_path):
    with open(key_file_path, "r") as f:
        
        preKey = key = f.read()
        preuser = preKey.split("-")[1]




font = ("Roboto-Bold", 18, "bold")
inputFont = ("Roboto-Bold", 10, "bold")
keyFont = ("Roboto-Bold", 8, "bold")
buttonFont = ("Roboto-Bold", 12, "bold")

sg.theme("DarkBlue2")


layout = [[sg.Column([[sg.Text("Intertok Games Login", font=font)]], element_justification="center", expand_x=True)], 
          
          [sg.Text("Key:", font=keyFont, justification="left"), sg.Text("", font=keyFont, key="errorMessage", text_color="red")], 
          [sg.Input(preKey, font=inputFont, size=(350, 1), expand_x=True, justification="center", key="key_input", border_width=0)], 
          
          [sg.Text("Username on TikTok:", font=keyFont, justification="left")],
          [sg.Text("", font=inputFont, size=(350, 1), expand_x=True, justification="center", key="username_input", background_color="#335267")],

          [sg.Combo(GAMES, size = (200, 1), default_value=GAMES[0], font=inputFont, readonly=True)],

          [sg.Column([[sg.Button("Login", font=buttonFont, border_width=0)]], element_justification="center", expand_x=True, background_color="#1a2835")],
          [sg.Column([[sg.Image(r"discord.png", key="IMAGE_DISCORD", background_color="#1a2835"), sg.Text(" ", size=(30, 1), background_color="#1a2835"), sg.Image(r"tiktok.png", key="IMAGE_TIKTOK", background_color="#1a2835")]], background_color="#1a2835")]]


# Create the window

window = sg.Window("Intertok Games Login", layout, size=(400, 285), finalize=True)
window[f'IMAGE_DISCORD'].bind("<Button-1>", "")
window[f'IMAGE_TIKTOK'].bind("<Button-1>", "")
# Create an event loop
while True:





    event, values = window.read(timeout=1)
    # End program if user closes window or
    # presses the OK button

    if "-" in window["key_input"].get():

        window["username_input"].update(window["key_input"].get().split("-")[1])

    if event == "OK" or event == sg.WIN_CLOSED:
        break
    elif event == "IMAGE_DISCORD":
        webbrowser.open(DISC_LINK)
    elif event == "IMAGE_TIKTOK":
        webbrowser.open(TIKTOK_LINK)
    elif event == "Login":
        success = keyauth.checkLicense(str(window["key_input"].get()))

        


        if success:
            window.close()

            #loop = asyncio.get_event_loop()
            #res = loop.run_until_complete(bsod_generator())

            import tiktokLiveApi
            tiktokLiveApi.streamerName = window["username_input"].get() 

            asyncio.run(tiktokLiveApi.main())
            #asyncio.run(tiktokLiveApi.main())
        else:
            window["errorMessage"].Update("WRONG KEY")
            pass
            

window.close()

