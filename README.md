# Standalone Build with CSharp Tests

This repository shows a few C# tests that use the page object model and AltTester® to test the Unity Endless Runner sample:
https://assetstore.unity.com/packages/essentials/tutorial-projects/endless-runner-sample-game-87901

## NuGet package

**This project already has the AltDriver inside, but otherwise would require adding the https://www.nuget.org/packages/AltTester-Driver package to work.**

### Running the tests on Windows or MacOS
The tests are meant to be run on a Windows or MacOS device.
Create a folder `App` under the project.

To start the tests, depending on your OS run:

❗ Starting with version 2.0.0, the AltTester® Desktop must be running on your PC while the tests are running.

- **Windows**:
    1. Download and install the AltTester® Desktop for Windows from [here](https://alttester.com/downloads/), then open it.
    2. Install Allure on your Windows by following the steps from [Scoop installation](https://docs.qameta.io/allure/#_windows) or [Manual installation](https://docs.qameta.io/allure/#_manual_installation)
    3. Instrument the TrashCat application using the latest version of AltTester® Unity SDK - for additional information you can follow [this tutorial](https://alttester.com/walkthrough-tutorial-upgrading-trashcat-to-2-0-x/#Instrument%20TrashCat%20with%20AltTester%20Unity%20SDK%20v.2.0.x)
    4. Create a folder `TrashCatWindows` under `App` and include the instrumented app under the App/TrashCatWindows/ folder.
    5. Create an `allureConfig.json` file under `bin/Debug/netcoreappX`. For the content of this file, please take a look at the following [example](https://docs.qameta.io/allure/#_config_samples)
    6. Run `./start_tests_Windows.sh` in your bash terminal.

- **MacOS**:
    1. Download and install the AltTester® Desktop for MacOS from [here](https://alttester.com/downloads/), then open it.
    2. Install Allure on your MacOS by using the following command in your terminal `brew install allure`.
    3. Instrument the TrashCat application using the latest version of AltTester® Unity SDK - for additional information you can follow [this tutorial](https://alttester.com/walkthrough-tutorial-upgrading-trashcat-to-2-0-x/#Instrument%20TrashCat%20with%20AltTester%20Unity%20SDK%20v.2.0.x)
    4. Create a folder `TrashCatMac` under `App` and include the instrumented app under the App/TrashCatMac/ folder.
    5. Create an `allureConfig.json` file under `bin/Debug/netcoreappX`. For the content of this file, please take a look at the following [example](https://docs.qameta.io/allure/#_config_samples)
    6. Run `./start_tests_Mac.sh` in your bash terminal.


❗ To manually open the Allure report, navigate to the `allure-reports` folder and open the `index.html` file [with live server](https://www.alphr.com/vs-code-open-with-live-server/).

   
This script will:

- start the app on your device
- create an `allure-results` folder
- run the tests
- generate and start the Allure report
- stop the app after the tests are done
