# Recepcja w hotelu

Okienkowa aplikacja wspomagająca pracę recepcjonisty w hotelu napisana w języku C#


### Technologie

.Net Framework(WinForms) 4.7.2 + MySQL database

### Instalacja

W celu instalacji programu należy stworzyć bazę danych z zaimplementowanym projektem bazodanowym MySQL zawartym w folderze /db/
Adres bazy nalezy wpisać w pliku passwd.txt stworzonym w foldzerze głownym programu według podanego schematu:
server=`mysql.example.com`,`portnumber`;database=`exampledb`;uid=`exampleid`;pwd=`examplepsw`;

Hasło dostępowe do aplikacji hashowane jest metodą md5. Wprowadzone dane testowe to `admin`, `admin`.

## Testy

W programie zostały zaimplementowane testy jednostkowe /TestResult/
Wynik ich działania znajduje się w folderze /TestResult/

