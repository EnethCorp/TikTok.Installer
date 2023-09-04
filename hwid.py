import hashlib
import psutil
import platform
import wmi

def get_baseboard_serial():
    try:
        c = wmi.WMI()
        baseboard = c.Win32_BaseBoard()[0]
        return baseboard.SerialNumber
    except Exception as e:
        return ""

def get_bios_serial():
    try:
        c = wmi.WMI()
        bios = c.Win32_BIOS()[0]
        return bios.SerialNumber
    except Exception as e:
        return ""

def get_processor_unique_id():
    try:
        c = wmi.WMI()
        processor = c.Win32_Processor()[0]
        return processor.UniqueId
    except Exception as e:
        return ""

def get_disk_drive_serial():
    try:
        c = wmi.WMI()
        disk_drive = c.Win32_DiskDrive()[0]
        return disk_drive.SerialNumber
    except Exception as e:
        return ""

def get_os_serial():
    try:
        c = wmi.WMI()
        os_info = c.Win32_OperatingSystem()[0]
        return os_info.SerialNumber
    except Exception as e:
        return ""

def generate_device_identifier():
    baseboard_serial = get_baseboard_serial()
    bios_serial = get_bios_serial()
    processor_unique_id = get_processor_unique_id()
    disk_drive_serial = get_disk_drive_serial()
    os_serial = get_os_serial()

    combined_info = f"{baseboard_serial}{bios_serial}{processor_unique_id}{disk_drive_serial}{os_serial}"
    unique_identifier = hashlib.sha256(combined_info.encode()).hexdigest()
    return unique_identifier

if platform.system() == "Windows":
    device_identifier = generate_device_identifier()
    print("Device Unique Identifier:", device_identifier)
else:
    print("This script is for Windows only.")