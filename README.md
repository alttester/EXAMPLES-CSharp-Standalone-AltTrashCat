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
- **MacOS**:
    1. Install the [AltTesterDesktop](https://alttester.com/app/uploads/AltTester/desktop/AltTesterDesktopPackageMac__v2.0.1.zip), then open it.
    2. Create a folder `TrashCatMac` under `App`.
    The app is provided at https://alttester.com/app/uploads/AltTester/TrashCat/TrashCat.app.zip and needs to be included unzipped under the App/TrashCatMac/ folder.
    3. run `./start_tests_Mac.sh` in your bash terminal.

- **Windows**:
    1. Install the [AltTesterDesktop](https://alttester.com/app/uploads/AltTester/desktop/AltTesterDesktopPackageWindows__v2.0.1.zip), then open it.
    2. Create a folder `TrashCatWindows` under `App`.
    The app is provided at https://alttester.com/app/uploads/AltTester/TrashCat/TrashCatStandAlone2_0_1.zip and needs to be included unzipped under the App/TrashCatWindows/ folder.
    3. run `./start_tests_Windows.sh` in your bash terminal

    
   
This script will:

- start the app on your device
- run the tests
- generate an allure html reporter
- stop the app after the test are done

You can view a video of how to run the tests on MAC OS by clicking on the following image: 

[![Youtube](http://img.youtube.com/vi/tr3_8YawBck/0.jpg)](https://www.youtube.com/embed/tr3_8YawBck "Youtube")
 