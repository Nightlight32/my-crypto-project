# my-crypto-project

# Содержание
- Сущности проекта
- UML-диаграмма классов
- Макеты интерфейса
- Проект CryptoProject

## Сущности проекта
Сущность **Form 1** - главное меню, отображает список методов и протоколов шифрования.    
Сущность **Form 2** - реализация метода "Шифр Цезаря". Содержит классы Clent и Caesar, отвечающие за замену символов и кодирование/декодирование текста.    
Сущность **Form 3** - реализация протокола Диффи-Хеллмана.

## UML-диаграмма классов
![Alt-текст](https://github.com/Nightlight32/my-crypto-project/blob/master/ClassDiagram.PNG "UML CryptoProject")

## Макеты интерфейса
![Alt-текст](https://github.com/Nightlight32/my-crypto-project/blob/master/main_menu.PNG "Главное меню программы")    
Главное окно состоит из двух кнопок, нажатие которых приводит к переходу к тому или иному шифру.
![Alt-текст](https://github.com/Nightlight32/my-crypto-project/blob/master/caesar.PNG "Окно раздела Шифр Цезаря")    
Окно "Шифр Цезаря": загрузите txt-файл, задайте длину ключа и зашифруйте/расшифруйте текст файла.
![Alt-текст](https://github.com/Nightlight32/my-crypto-project/blob/master/diffie_hellman.PNG "Окно раздела Диффи-Хеллман")    
Окно "Диффи-Хеллман": введите секретное число, основание, числа Алисы и Боба для передачи, и получите публичные и секретные ключи.    

## Проект CryptoProject
[Ссылка на тестовый проект CryptoProject](https://github.com/Nightlight32/my-crypto-project)
