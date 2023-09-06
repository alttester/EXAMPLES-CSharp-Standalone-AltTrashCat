echo "==> Open application..."
open App/TrashCatMac/TrashCat.app

echo "==>Wait for application to start"
sleep 3

echo "==>Restore test project and run tests"
dotnet test --results-directory allure-results

echo "Generate allure html report..."
allure serve allure-results &

echo "==>Kill app"
killall TrashCat
