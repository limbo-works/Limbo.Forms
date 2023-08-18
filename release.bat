@echo off

dotnet build src/Limbo.Forms --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget