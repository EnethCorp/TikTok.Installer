'''
KeyAuth.cc Python Example

Go to https://keyauth.cc/app/ and click the Python tab. Copy that code and replace the existing keyauthapp instance in this file.

If you get an error saying it can't find module KeyAuth, try following this https://github.com/KeyAuth/KeyAuth-Python-Example#how-to-compile

If that doesn't work for you, you can paste the contents of KeyAuth.py ABOVE this comment and then remove the "from keyauth import api" and that should work too.

READ HERE TO LEARN ABOUT KEYAUTH FUNCTIONS https://github.com/KeyAuth/KeyAuth-Python-Example#keyauthapp-instance-definition
'''
from keyauth import api

import sys
import time
import platform
import os
import hashlib
from time import sleep
from datetime import datetime
import sys
from pathlib import Path
from os import getenv
from hwid import generate_device_identifier
import win32security


def clear():
    if platform.system() == 'Windows':
        os.system('cls & title Python Example')  # clear console, change title
    elif platform.system() == 'Linux':
        os.system('clear')  # clear console
        sys.stdout.write("\x1b]0;Python Example\x07")  # change title
    elif platform.system() == 'Darwin':
        os.system("clear && printf '\e[3J'")  # clear console
        os.system('''echo - n - e "\033]0;Python Example\007"''')  # change title

def getchecksum():
    md5_hash = hashlib.md5()
    file = open(''.join(sys.argv), "rb")
    md5_hash.update(file.read())
    digest = md5_hash.hexdigest()
    return digest

def get_hwid():
    if platform.system() == "Linux":
        with open("/etc/machine-id") as f:
            hwid = f.read()
            return hwid
    elif platform.system() == 'Windows':
        winuser = os.getlogin()
        sid = win32security.LookupAccountName(None, winuser)[0]  # You can also use WMIC (better than SID, some users had problems with WMIC)
        print(sid)
        hwid = win32security.ConvertSidToStringSid(sid)
        return hwid

def checkLicense(key: str):

    print("Initializing")
    keyauthapp = api(
        name = "Tiktok.BallGame",
        ownerid = "qdPVeuvG2s",
        secret = "44d7d1eff612aa588fedfcff6768e97a8fa1ee541a9486a00e1ed7f418fbc244",
        version = "1.0",
        hash_to_check = getchecksum()
    )

    appdata =  os.path.abspath(os.path.join(os.getenv("LOCALAPPDATA"), os.pardir))
    key_path = os.path.join(appdata, "LocalLow\DefaultCompany\Tiktok_BallGame\\") + "key"
    hwid_path = os.path.join(appdata, "LocalLow\DefaultCompany\Tiktok_BallGame\\") + "hwid"
    parent_directory = os.path.abspath(os.path.join(key_path, os.pardir))
    
    print(key_path)
    print(parent_directory)

    # Check for file
    if not os.path.exists(key_path):
        try:
            os.mkdir(parent_directory)
        except:
            print("Directory already exists.")
        try:
            open(key_path, "w+")
        except:
            print("Could not create key file")
        try:
            open(hwid_path, "w+")
        except:
            print("Could not create hwid file")


    # HWID
    hwid = get_hwid()
    print(hwid)

    with open(hwid_path, "w") as file:
        file.write(hwid + "\n")
    
    with open(key_path, "w") as file:
        file.write(key + "\n")

    print(key)

    success = keyauthapp.license(key, hwid=hwid)

    if not success:
        os.remove(key_path)
        
    return success



# Main
if __name__ == "__main__":
    checkLicense("KEYAUTH-asdgf")