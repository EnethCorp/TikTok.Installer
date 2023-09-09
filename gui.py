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
unity_path = os.path.join(appdata, r"local\DefaultCompany\Tiktok_BallGame\Tiktok.BallGame.exe")
username_path = os.path.join(appdata, r"locallow\DefaultCompany\Tiktok_BallGame\username")

preKey = ""
if os.path.exists(key_file_path):
    with open(key_file_path, "r") as f:
        preKey = f.read()

preUser = ""
if os.path.exists(username_path):
    with open(username_path, "r") as f:
        preUser = f.read()


font = ("Roboto-Bold", 18, "bold")
inputFont = ("Roboto-Bold", 10, "bold")
keyFont = ("Roboto-Bold", 8, "bold")
buttonFont = ("Roboto-Bold", 12, "bold")

layout = [[sg.Column([[sg.Text("Intertok Games Login", font=font, background_color="#1a2835")]], element_justification="center", expand_x=True, background_color="#1a2835")], 
          
          [sg.Text("Username on TikTok:", font=keyFont, justification="left", background_color="#1a2835")],
          [sg.Input(preUser, font=inputFont, size=(350, 1), expand_x=True, justification="center", key="username_input")],
          
          [sg.Text("Key:", font=keyFont, justification="left", background_color="#1a2835"), sg.Text("", font=keyFont, key="errorMessage", text_color="red", background_color="#1a2835")], 
          [sg.Input(preKey, font=inputFont, size=(350, 1), expand_x=True, justification="center", key="key_input")], 
          
          [sg.Column([[sg.Button("Login", font=buttonFont)]], element_justification="center", expand_x=True, background_color="#1a2835")],
          [sg.Text("\n", background_color="#1a2835")],
          [sg.Column([[sg.Image(r"discord.png", key="IMAGE_DISCORD", background_color="#1a2835"), sg.Text(" ", size=(30, 1), background_color="#1a2835"), sg.Image(r"tiktok.png", key="IMAGE_TIKTOK", background_color="#1a2835")]], background_color="#1a2835")]]


# Create the window
sg.theme("DarkBlue2")
window = sg.Window("Intertok Games Login", layout, size=(400, 250), finalize=True)
window[f'IMAGE_DISCORD'].bind("<Button-1>", "")
window[f'IMAGE_TIKTOK'].bind("<Button-1>", "")
# Create an event loop
while True:
    event, values = window.read()
    # End program if user closes window or
    # presses the OK button
    print(event)
    if event == "OK" or event == sg.WIN_CLOSED:
        break
    elif event == "IMAGE_DISCORD":
        webbrowser.open(DISC_LINK)
    elif event == "IMAGE_TIKTOK":
        webbrowser.open(TIKTOK_LINK)
    elif event == "Login":
        success = keyauth.checkLicense(str(window["key_input"].get()))

        with open(username_path, "w") as f:
            f.write(window["username_input"].get())


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

