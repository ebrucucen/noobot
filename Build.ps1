dotnet restore ".\Noobot.sln" -r "win-x64"

dotnet build -c "Release" -r "win-x64" -f "netcoreapp2.0"

dotnet pack  ".\src\Noobot.Core\Noobot.Core.csproj" --configuration Release --output ".\nupkgs" --no-build --no-restore --runtime "win-x64" 
