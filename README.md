## Kiindulás
- A HTML oldal készen van (`index.html`).
- A JavaScript fájlban csak a megvalósítandó függvények szerepelnek (`main.js`).

Készítsd el a backend alkalmazást (ASP.NET Core API) a könyvek számára.
Készítsd el a megfelelő rétegeket hozzá. (Adatbázis - repository - api)
Az adatbázis kiváltható memória beli gyűjtemény listával.
A végpontok a szokásos CRUD műveletek legyenek. Legyen tesztelhető swaggerből
A repository réteggel interfacen keresztül kommunikáljunk.



## Kliens rész
1. Valósítsd meg a `downloadAndDisplay()` függvényt. Lekéri az összes könyvet és megjelenít. Legyen egy 'actions' oszlop az update és delete műveletekkel. 
2. Valósítsd meg a `loadForUpdate(event)` függvényt. Betölti a frissítésre váró könyvet a formba.
3. Valósítsd meg a `deleteBook(event)` függvényt. Töröl egy könyvet.
4. Valósítsd meg a `resetForm()` függvényt. 
5. Valósítsd meg a `addTemp()` függvényt. ()
6. Valósítsd meg a `createBook()` függvényt. 
7. Valósítsd meg a `updateBook()` függvényt.
8. Hívd meg induláskor a `downloadAndDisplay()` függvényt.
