Для запуска необходимо:

Установить PostgresSQL
создать БД: "Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=2"

Создать таблицу Orders со столбцами:

 	Id (тип integer)
        Number (тип text)
        SendersCity (тип text)
        SendersAddress (тип text)
        ReceiversCity (тип text)
        ReceiversAddress (тип text)
        CargoWeight (тип integer)
        DateOfCargoPickup (тип date)

Запустить проэкт в любой удобной среде разработки для C#
