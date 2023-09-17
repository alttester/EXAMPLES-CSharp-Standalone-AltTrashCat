echo "==> Open application..."
open App/TrashCatMac/TrashCat.app

echo "==>Wait for application to start"
sleep 3

echo "==>Restore test project and run tests"
dotnet test --results-directory allure-results

echo "Generate allure html report..."
allure generate allure-results -o allure-reports

echo "==>Kill app"
killall TrashCat
