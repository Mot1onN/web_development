# «FunFinder»


## Запуск в VS Code

Понадобится .NET 10 SDK. Откройте папку репозитория в VS Code и выполните из её терминала:

```sh
dotnet build FunFinder.slnx
dotnet run --project src/FunFinder.Web --launch-profile http
```

Откройте [http://localhost:5236](http://localhost:5236). Чтобы остановить приложение, нажмите `Ctrl+C` в терминале.
