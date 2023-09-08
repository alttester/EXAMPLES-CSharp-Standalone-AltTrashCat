# Standalone Build with CSharp Tests

This repository shows a few C# tests that use the page object model and AltTester to test the Unity endless runner sample:
https://assetstore.unity.com/packages/essentials/tutorial-projects/endless-runner-sample-game-87901

## NuGet package

**This project already has the AltDriver inside, but otherwise would require to add https://www.nuget.org/packages/AltTester-Driver package in order to work.**

### Running the tests on Windows or MacOS
The tests are meant to be run on an Windows or MacOS device.
Create a folder `App` under project.

To start the tests, depending of your OS run:

❗ Starting with version 2.0.0, the AltTester Desktop must be running on your PC while the tests are running.

- **Windows**:
    1. Install the [AltTesterDesktop](https://alttester.com/app/uploads/AltTester/desktop/AltTesterDesktopPackageWindows__v2.0.1.zip), then open it.
    2. Install Allure on your Windows by following the steps from [Scoop installation](https://docs.qameta.io/allure/#_windows) or [Manual installation](https://docs.qameta.io/allure/#_manual_installation)
    3. Create a folder `TrashCatWindows` under `App`.
    The app is provided at https://alttester.com/app/uploads/AltTester/TrashCat/TrashCatStandAlone2_0_1.zip and needs to be included unzipped under the App/TrashCatWindows/ folder.
    4. Create a folder called `allure-results` and `allure-report` under the project.
    5. Create an `allureConfig.json` file under `bin/Debug/netcoreappX`. For the content of this file, please take a look at the following [example](https://docs.qameta.io/allure/#_config_samples)
    6. run `./start_tests_Windows.sh` in your bash terminal

- **MacOS**:
    1. Install the [AltTesterDesktop](https://alttester.com/app/uploads/AltTester/desktop/AltTesterDesktopPackageMac__v2.0.1.zip), then open it.
    2. Install Allure on your MacOS by using the following command in your terminal `brew install allure`.
    3. Create a folder `TrashCatMac` under `App`.
    The app is provided at https://alttester.com/app/uploads/AltTester/TrashCat/TrashCat.app.zip and needs to be included unzipped under the App/TrashCatMac/ folder.
    4. Create a folder called `allure-results` and `allure-report` under the project
    5. Create an `allureConfig.json` file under `bin/Debug/netcoreappX`. For the content of this file, please take a look at the following [example](https://docs.qameta.io/allure/#_config_samples)
    6. run `./start_tests_Mac.sh` in your bash terminal.


❗ To see the allure report, navigate to the `allure-reports` folder and open the `index.html` file [with live server](https://www.alphr.com/vs-code-open-with-live-server/).

   
This script will:

- start the app on your device
- run the tests
- generate an allure html reporter
- stop the app after the tests are done
