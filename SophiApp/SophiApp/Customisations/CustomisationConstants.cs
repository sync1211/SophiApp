﻿using System;

namespace SophiApp.Customisations
{
    internal static class CustomisationConstants
    {
        internal const string _100_DIAG_TRACK = "DiagTrack";
        internal const string _104_CORE = "Core";
        internal const string _104_DISABLED = "Disabled";
        internal const byte _104_DISABLED_DEFAULT_VALUE = 1;
        internal const string _104_QUEUE_TASK = "QueueReporting";
        internal const string _104_QUEUE_TASK_PATH = @"Microsoft\Windows\Windows Error Reporting";
        internal const string _104_WER_PATH = @"SOFTWARE\Microsoft\Windows\Windows Error Reporting";
        internal const string _104_WER_SERVICE = "WerSvc";
        internal const string _109_DATA_UPDATER_TASK = "ProgramDataUpdater";
        internal const string _109_DATA_UPDATER_TASK_PATH = @"Microsoft\Windows\Application Experience";
        internal const string _110_PROXY_TASK = "Proxy";
        internal const string _110_PROXY_TASK_PATH = @"Microsoft\Windows\Autochk";
        internal const string _111_CONS_TASK = "Consolidator";
        internal const string _112_USB_CEIP_TASK = "UsbCeip";
        internal const string _113_DISK_DATA_TASK = "Microsoft-Windows-DiskDiagnosticDataCollector";
        internal const string _113_DISK_DATA_TASK_PATH = @"Microsoft\Windows\DiskDiagnostic";
        internal const string _114_MAPS_TOAST_TASK = "MapsToastTask";
        internal const string _115_MAPS_UPDATE = "MapsUpdateTask";
        internal const string _116_FAMILY_MONITOR_TASK = "FamilySafetyMonitor";
        internal const string _116_FAMILY_MONITOR_TASK_PATH = @"Microsoft\Windows\Shell";
        internal const string _117_XBOX_SAVE_TASK = "XblGameSaveTask";
        internal const string _117_XBOX_SAVE_TASK_PATH = @"Microsoft\XblGameSave";
        internal const string _118_OPT_OUT = "OptOut";
        internal const byte _118_OPT_OUT_DEFAULT_VALUE = 1;
        internal const string _118_USER_ARSO_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\UserARSO";
        internal const string _119_HTTP_ACCEPT = "HttpAcceptLanguageOptOut";
        internal const byte _119_HTTP_ACCEPT_DEFAULT_VALUE = 1;
        internal const string _119_USER_PROFILE_PATH = @"Control Panel\International\User Profile";
        internal const string _120_ADVERT_ENABLED = "Enabled";
        internal const string _120_ADVERT_INFO_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo";
        internal const string _121_SUB_CONTENT = "SubscribedContent-310093Enabled";
        internal const string _122_SUB_CONTENT = "SubscribedContent-338389Enabled";
        internal const string _123_SUB_CONTENT_93 = "SubscribedContent-338393Enabled";
        internal const string _123_SUB_CONTENT_94 = "SubscribedContent-353694Enabled";
        internal const string _123_SUB_CONTENT_96 = "SubscribedContent-353696Enabled";
        internal const string _124_SILENT_APP_INSTALL = "SilentInstalledAppsEnabled";
        internal const string _125_PROFILE_ENGAGE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\UserProfileEngagement";
        internal const string _125_SETTING_ENABLED = "ScoobeSystemSettingEnabled";
        internal const string _126_PRIVACY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Privacy";
        internal const string _126_TAILORED_DATA = "TailoredExperiencesWithDiagnosticDataEnabled";
        internal const string _127_DISABLE_SEARCH_SUGGESTIONS = "DisableSearchBoxSuggestions";
        internal const string _203_AUTO_CHECK_SELECT = "AutoCheckSelect";
        internal const byte _204_DISABLED_VALUE = 2;
        internal const byte _204_ENABLED_VALUE = 1;
        internal const string _204_HIDDEN = "Hidden";
        internal const string _205_HIDE_FILE_EXT = "HideFileExt";
        internal const byte _205_HIDE_VALUE = 1;
        internal const byte _205_SHOW_VALUE = 0;
        internal const string _206_HIDE_MERGE_CONF = "HideMergeConflicts";
        internal const string _210_CORTANA = "Microsoft.549981C3F5F10";
        internal const string _210_CORTANA_BUTTON = "ShowCortanaButton";
        internal const string _211_SHOW_SYNC_PROVIDER = "ShowSyncProviderNotifications";
        internal const string _212_SNAP_ASSIST = "SnapAssist";
        internal const string _213_FEEDS_PATH = @"Software\Microsoft\Windows\CurrentVersion\Feeds";
        internal const byte _216_EXPANDED_VALUE = 0;
        internal const byte _216_MINIMIZED_VALUE = 1;
        internal const string _216_RIBBON_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Ribbon";
        internal const string _216_TABLET_MODE_OFF = "MinimizedStateTabletModeOff";
        internal const byte _217_SHELL_DISABLED_VALUE = 55;
        internal const byte _217_SHELL_ENABLED_VALUE = 51;
        internal const string _217_SHELL_STATE = "ShellState";
        internal const string _218_3D_OBJECT_HIDE_VALUE = "Hide";
        internal const string _218_3D_OBJECT_PROPERTY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag";
        internal const string _218_PC_POLICY = "ThisPCPolicy";
        internal const string _219_SHOW_RECENT = "ShowRecent";
        internal const string _220_SHOW_FREQUENT = "ShowFrequent";
        internal const string _221_SHOW_TASK_VIEW = "ShowTaskViewButton";
        internal const string _222_PEOPLE_BAND = "PeopleBand";
        internal const string _222_PEOPLE_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People";
        internal const string _223_SHOW_SECONDS = "ShowSecondsInSystemClock";
        internal const string _228_PEN_WORKSPACE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\PenWorkspace";
        internal const string _228_PEN_WORKSPACE_VISIBILITY = "PenWorkspaceButtonDesiredVisibility";
        internal const string _229_AUTO_TRAY = "EnableAutoTray";
        internal const byte _229_AUTO_TRAY_HIDE_VALUE = 1;
        internal const byte _229_AUTO_TRAY_SHOW_VALUE = 0;
        internal const byte _230_STUCK_RECTS3_HIDE_VALUE = 128;
        internal const string _230_STUCK_RECTS3_PATH = @"Software\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3";
        internal const string _230_STUCK_RECTS3_SETTINGS = "Settings";
        internal const byte _230_STUCK_RECTS3_SHOW_VALUE = 0;
        internal const string _231_SHELL_FEEDS = "ShellFeedsTaskbarViewMode";
        internal const byte _231_SHELL_FEEDS_DISABLED_VALUE = 2;
        internal const byte _231_SHELL_FEEDS_ENABLED_VALUE = 0;
        internal const byte _242_HIDE_ALERT_VALUE = 1;
        internal const string _242_NO_NEW_APP_ALERT = "NoNewAppAlert";
        internal const byte _242_SHOW_ALERT_VALUE = 0;
        internal const string _243_FIRST_LOGON_ANIMATION = "EnableFirstLogonAnimation";
        internal const string _243_WINLOGON_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
        internal const byte _245_JPEG_MAX_QUALITY = 100;
        internal const byte _247_HIDE_VALUE = 0;
        internal const string _247_RESTART_NOTIFICATIONS = "RestartNotificationsAllowed2";
        internal const byte _247_SHOW_VALUE = 1;
        internal const string _247_WINDOWS_UPDATE_SETTINGS_PATH = @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings";
        internal const string _248_DISABLE_VALUE = "%s.lnk";
        internal const string _248_EXPLORER_NAMING_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\NamingTemplates";
        internal const string _248_LINK = "link";
        internal const string _248_SHORTCUT = "ShortcutNameTemplate";
        internal const string _249_CONTROL_PANEL_KEYBOARD_PATH = @"Control Panel\Keyboard";
        internal const string _249_PRINT_SCREEN_SNIPPING = "PrintScreenKeyForSnippingEnabled";
        internal const byte _251_DISABLED_VALUE = 1;
        internal const string _251_DISALLOW_WINDOWS_SHAKE = "DisallowShaking";
        internal const byte _251_ENABLED_VALUE = 0;
        internal const byte _302_STORAGE_POLICY_MONTH_VALUE = 30;
        internal const string _304_STORAGE_POLICY_04 = "04";
        internal const byte _305_ENABLED_VALUE = 1;
        internal const string _305_HIBERNATE = "HibernateEnabled";
        internal const string _305_HIBERNATE_OFF = "/HIBERNATE OFF";
        internal const string _305_HIBERNATE_ON = "/HIBERNATE ON";
        internal const string _305_POWER_CONTROL_PATH = @"SYSTEM\CurrentControlSet\Control\Power";
        internal const string _305_POWERCFG = "powercfg.exe";
        internal const string _307_SYMBOLIC_LINK_TASK = "SymbolicLink";
        internal const string _307_SYSTEM_DRIVE_TEMP = @"%SystemDrive%\Temp";
        internal const string _307_TASK_ARGS = "-WindowStyle Hidden -Command \"Start-Transcript -Path 'C:\\Temp\\PowershellLog.txt'; Get-ChildItem -Path $env:SystemRoot\\Temp -Recurse -Force | Remove-Item -Recurse -Force; Get-ChildItem -Path $env:LOCALAPPDATA\\Temp -Recurse -Force | Remove-Item -Recurse -Force; Get-Item -Path $env:LOCALAPPDATA\\Temp -Force | Where-Object -FilterScript {$_.LinkType -ne 'SymbolicLink'} | Remove-Item -Recurse -Force; New-Item -Path $env:LOCALAPPDATA\\Temp -ItemType SymbolicLink -Value $env:SystemDrive\\Temp -Force; Unregister-ScheduledTask -TaskName SymbolicLink -Confirm:$false; Stop-Transcript\"";
        internal const string _308_APPDATA_TEMP = @"%USERPROFILE%\AppData\Local\Temp";
        internal const string _308_TASK_ARGS = "-WindowStyle Hidden -Command \"Start-Transcript -Path 'C:\\Temp\\PowershellLog.txt'; Remove-Item -Path $env:SystemDrive\\Temp -Recurse -Force; Unregister-ScheduledTask -TaskName TemporaryTask -Confirm:$false; Stop-Transcript\"";
        internal const string _308_TEMPORARY_TASK = "TemporaryTask";
        internal const string _309_CONTROL_FILE_SYSTEM_PATH = @"SYSTEM\CurrentControlSet\Control\FileSystem";
        internal const byte _309_DISABLED_VALUE = 1;
        internal const byte _309_ENABLED_VALUE = 0;
        internal const string _309_LONG_PATH = "LongPathsEnabled";
        internal const string _310_DISPLAY_PARAMS = "DisplayParameters";
        internal const string _310_SYSTEM_CRASH_CONTROL_PATH = @"SYSTEM\CurrentControlSet\Control\CrashControl";
        internal const string _314_ENABLE_LINKED = "EnableLinkedConnections";
        internal const byte _314_ENABLE_LINKED_VALUE = 1;
        internal const string _315_DELIVERY_SETTINGS_PATH = @"S-1-5-20\SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Settings";
        internal const string _315_DOWNLOAD_MODE = "DownloadMode";
        internal const string _316_FOREGROUND_POLICY = "SyncForegroundPolicy";
        internal const string _316_WINLOGON_PATH = @"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\Winlogon";
        internal const string _317_CURRENT_VERSION_WINDOWS_PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows";
        internal const byte _317_DISABLED_VALUE = 1;
        internal const byte _317_ENABLED_VALUE = 0;
        internal const string _317_PRINTER_LEGACY_MODE = "LegacyDefaultPrinterMode";
        internal const string _319_LEGACY_COMPONENTS_FEATURE = "LegacyComponents";
        internal const string _320_POWERSHELL_V2_FEATURE = "MicrosoftWindowsPowerShellV2";
        internal const string _321_POWERSHELL_V2_ROOT_FEATURE = "MicrosoftWindowsPowershellV2Root";
        internal const string _322_XPS_SERVICES_FEATURE = "Printing-XPSServices-Features";
        internal const string _323_WORK_FOLDERS_FEATURE = "WorkFolders-Client";
        internal const string _324_MEDIA_PLAYBACK_FEATURE = "MediaPlayback";
        internal const string _800_MSI_EXTRACT_COM_PATH = @"Msi.Package\shell\Extract\Command";
        internal const string _800_MSI_EXTRACT_PATH = @"Msi.Package\shell\Extract";
        internal const string _800_MSI_EXTRACT_VALUE = "msiexec.exe /a \"%1\" /qb TARGETDIR=\"%1 extracted\"";
        internal const string _800_MSI_ICON = "Icon";
        internal const string _800_MSI_ICON_VALUE = "shell32.dll,-16817";
        internal const string _800_MSI_MUIVERB_VALUE = "@shell32.dll,-37514";
        internal const string _801_CAB_COM_PATH = @"CABFolder\Shell\RunAs\Command";
        internal const string _801_CAB_LUA_SHIELD = "HasLUAShield";
        internal const string _801_CAB_RUNAS_PATH = @"CABFolder\Shell\RunAs";
        internal const string _801_CAB_VALUE = "cmd /c DISM.exe /Online /Add-Package /PackagePath:\"%1\" /NoRestart & pause\"";
        internal const string _801_MUIVERB_VALUE = "@shell32.dll,-10210";
        internal const string _802_EXTENDED = @"Extended";
        internal const string _802_RUNAS_USER_PATH = @"exefile\shell\runasuser";
        internal const string _803_CAST_TO_DEV_GUID = @"{7AD84985-87B4-4a16-BE58-8B72A5B390F7}";
        internal const string _803_CAST_TO_DEV_VALUE = "Play to menu";
        internal const string _804_SHARE_GUID = @"{E2BF9676-5F8F-435C-97EB-11607A5BEDF7}";
        internal const string _805_MS_PAINT_3D = "Microsoft.MSPaint";
        internal const string _806_BMP_EXT = @"SystemFileAssociations\.bmp\Shell\3D Edit";
        internal const string _807_GIF_EXT = @"SystemFileAssociations\.gif\Shell\3D Edit";
        internal const string _808_JPE_EXT = @"SystemFileAssociations\.jpe\Shell\3D Edit";
        internal const string _809_JPEG_EXT = @"SystemFileAssociations\.jpeg\Shell\3D Edit";
        internal const string _810_JPG_EXT = @"SystemFileAssociations\.jpg\Shell\3D Edit";
        internal const string _811_PNG_EXT = @"SystemFileAssociations\.png\Shell\3D Edit";
        internal const string _812_TIF_EXT = @"SystemFileAssociations\.tif\Shell\3D Edit";
        internal const string _813_TIFF_EXT = @"SystemFileAssociations\.tiff\Shell\3D Edit";
        internal const string _814_PHOTOS_SHELL_EDIT_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellEdit";
        internal const string _815_PHOTOS_SHELL_VIDEO_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellCreateVideo";
        internal const string _816_IMG_SHELL_EDIT_PATH = @"SystemFileAssociations\image\shell\edit";
        internal const string _817_BAT_SHELL_EDIT_PATH = @"batfile\shell\print";
        internal const string _817_CMD_SHELL_EDIT_PATH = @"cmdfile\shell\print";
        internal const string _818_HIDE_VALUE = "-{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _818_LIB_LOCATION_PATH = @"Folder\ShellEx\ContextMenuHandlers\Library Location";
        internal const string _818_SHOW_VALUE = "{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _819_HIDE_VALUE = "-{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _819_SEND_TO_PATH = @"AllFilesystemObjects\shellex\ContextMenuHandlers\SendTo";
        internal const string _819_SHOW_VALUE = "{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _820_BITLOCKER_BDELEV_PATH = @"Drive\shell\encrypt-bde-elev";
        internal const string _821_BMP_ITEM_NAME = "ItemName";
        internal const string _821_BMP_ITEM_VALUE = @"@%systemroot%\system32\mspaint.exe,-59414";
        internal const string _821_BMP_NULL_FILE = "NullFile";
        internal const string _821_BMP_SHELL_NEW = @".bmp\ShellNew";
        internal const string _822_DATA_VALUE = "{\rtf1}";
        internal const string _822_ITEM_VALUE = @"@%ProgramFiles%\Windows NT\Accessories\WORDPAD.EXE,-213";
        internal const string _822_MS_WORD_PAD = "Microsoft.Windows.WordPad~~~~0.0.1.0";
        internal const string _822_RTF_SHELL_NEW = @".rtf\ShellNew";
        internal const string _823_ITEM_DATA = @"@%SystemRoot%\system32\zipfldr.dll,-10194";
        internal const string _823_ZIP_SHELLNEW_PATH = @".zip\CompressedFolder\ShellNew";
        internal const string _824_PROMPT_NAME = "MultipleInvokePromptMinimum";
        internal const int _824_PROMPT_VALUE = 300;
        internal const string _825_NO_USE_NAME = "NoUseStoreOpenWith";
        internal const byte _825_NO_USE_VALUE = 1;
        internal const string ADMIN_PROMPT = "ConsentPromptBehaviorAdmin";
        internal const byte ADMIN_PROMPT_DEFAULT_VALUE = 5;
        internal const byte ADMIN_PROMPT_NEVER_VALUE = 0;
        internal const string ADVANCED_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        internal const byte ALL_ITEMS_ICON_CATEGORY_VALUE = 0;
        internal const byte ALL_ITEMS_ICON_SMALL_VALUE = 1;
        internal const string ALL_ITEMS_ICON_VIEW = "AllItemsIconView";
        internal const string ALLOW_TELEMETRY = "AllowTelemetry";
        internal const string APPS_USES_THEME = "AppsUseLightTheme";
        internal const string CAPABILITY_MS_PAINT = "Microsoft.Windows.MSPaint~~~~0.0.1.0";
        internal const string CEIP_TASK_PATH = @"Microsoft\Windows\Customer Experience Improvement Program";
        internal const string CONTENT_DELIVERY_MANAGER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        internal const string CONTROL_PANEL_DESKTOP_PATH = @"Control Panel\Desktop";
        internal const string CONTROL_PANEL_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel";
        internal const string CURRENT_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer";
        internal const byte DARK_THEME_VALUE = 0;
        internal const string DATA = "Data";
        internal const string DATA_COLLECTION_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection";
        internal const byte DEFAULT_TELEMETRY_VALUE = 3;
        internal const string DESKTOP_ICON_THIS_COMPUTER = "{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        internal const string DIAG_TRACK_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Diagnostics\DiagTrack";
        internal const byte DIALOG_COMPACT_VALUE = 0;
        internal const byte DIALOG_DETAILED_VALUE = 1;
        internal const byte DISABLED_VALUE = 0;
        internal const byte ENABLED_VALUE = 1;
        internal const string ENTHUSIAST_MODE = "EnthusiastMode";
        internal const string ENVIRONMENT = "Environment";
        internal const string ENVIRONMENT_LOCAL_APPDATA = "%LOCALAPPDATA%";
        internal const string ENVIRONMENT_SYSTEM_DRIVE = "%SystemDrive%";
        internal const string ENVIRONMENT_SYSTEM_ROOT = "%SystemRoot%";
        internal const string ENVIRONMENT_TEMP = "%TEMP%";
        internal const string ITEM_NAME = "ItemName";
        internal const string JPEG_QUALITY = "JPEGImportQuality";
        internal const byte LAUNCH_PC_VALUE = 1;
        internal const byte LAUNCH_QA_VALUE = 2;
        internal const string LAUNCH_TO = "LaunchTo";
        internal const byte LIGHT_THEME_VALUE = 1;
        internal const string MAPS_TASK_PATH = @"Microsoft\Windows\Maps";
        internal const string MAX_TELEMETRY_ALLOWED = "MaxTelemetryAllowed";
        internal const byte MIN_ENT_TELEMETRY_VALUE = 0;
        internal const byte MIN_TELEMETRY_VALUE = 1;
        internal const string MUIVERB = "MUIVerb";
        internal const string ONE_DRIVE = "OneDrive";
        internal const string ONE_DRIVE_AUTH = "FileCoAuth";
        internal const string PERSONALIZE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        internal const string POLICIES_EXPLORER_PATH = @"SOFTWARE\Policies\Microsoft\Windows\Explorer";
        internal const string POLICIES_SYSTEM_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
        internal const string POWERSHELL_EXE = "powershell.exe";
        internal const string PROGRAM_ACCESS_ONLY = "ProgrammaticAccessOnly";
        internal const string SERVICE_SPOOLER = "Spooler";
        internal const string SESSION_MANAGER_ENVIRONMENT = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
        internal const string SHELL_EXT_BLOCKED_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
        internal const string SHOWED_TOAST_LEVEL = "ShowedToastAtLevel";
        internal const string SIUF_PATH = @"SOFTWARE\Microsoft\Siuf\Rules";
        internal const string SIUF_PERIOD = "NumberOfSIUFInPeriod";
        internal const string START_PANEL_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel";
        internal const string STARTUP_PAGE = "StartupPage";
        internal const byte STARTUP_PAGE_CATEGORY_VALUE = 0;
        internal const byte STARTUP_PAGE_ICON_VALUE = 1;
        internal const string STATUS_MANAGER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager";
        internal const string STORAGE_POLICY_01 = "01";
        internal const string STORAGE_POLICY_2048 = "2048";
        internal const string STORAGE_POLICY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy";
        internal const string SYSTEM_USES_THEME = "SystemUsesLightTheme";
        internal const byte TASKBAR_SEARCH_BOX_VALUE = 2;
        internal const byte TASKBAR_SEARCH_HIDE_VALUE = 0;
        internal const byte TASKBAR_SEARCH_ICON_VALUE = 1;
        internal const string TASKBAR_SEARCH_MODE = "SearchboxTaskbarMode";
        internal const string TASKBAR_SEARCH_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Search";
        internal const string TEMP = "TEMP";
        internal const string TEMP_FOLDER = "Temp";
        internal const string TMP = "TMP";
        internal const string UWP_MS_WIN_PHOTOS = "Microsoft.Windows.Photos";
        internal const string WIN_VER_EDU = "Education";
        internal const string WIN_VER_ENT = "Enterprise";
        internal const string WIN_VER_PRO = "Professional";
        internal static string _315_DELIVERY_OPT_PATH = $@"{Environment.GetEnvironmentVariable("SystemRoot")}\SoftwareDistribution\DeliveryOptimization";
        internal static byte[] _823_ZIP_DATA = new byte[] { 80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}