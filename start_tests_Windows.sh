echo "==> Start application..."
start "" "App\TrashCatWindows\TrashCat.exe"

echo "==> Wait for app to start..."
sleep 5
# cd TestAlttrashCSharp

echo "==> Restore test project and run tests..."
dotnet test  -- NUnit.TestOutputXml = "TestAlttrashCSharp" --results-directory allure-results

echo "Generate allure html report..."
allure serve allure-results &

echo "==> Kill app..."
taskkill //PID $(tasklist | grep TrashCat.exe | awk '{print $2}') //T //F