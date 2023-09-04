import psutil
import asyncio

bsod_processes = ["ProcessHacker", "dnSpy", "HxD", "BinaryNinja", "Ida", "Ida Pro", "Ida Freeware", "HTTP Debugger Pro", "Fiddler"]

async def bsod_generator():
    while (True):
        for proc in psutil.process_iter():

            process = proc.name().removesuffix(".exe")
                
            for bsod_process in bsod_processes:
                if process == bsod_process:
                    ## ADD BLUE SCREEN LOGIC
                    print("The process is running")
                    break
                
        await asyncio.sleep(5)

# loop = asyncio.get_event_loop()
# res = loop.run_until_complete(bsod_generator())