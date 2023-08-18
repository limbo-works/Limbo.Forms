@echo off

dotnet build src/Limbo.Forms --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:/nuget