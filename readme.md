# Замена схожих русских символов на английские аналоги

## Описание

Начертание различных букв зависит от шрифта, которым напечатан текст. Всё ниженаписанное справедливо для наиболее распространённых шрифтов:
1. Courier New
2. Times New Roman
3. Arial
4. Roboto
5. Helvetica Neue

И некоторых других.

## Обзор существующих решений

В статье: http://wordexpert.ru/page/psevdokirillica-makros-zameny-latinicy-na-kirillicu  
Приводятся 19 правил для замены символов.  

Перечислим их:  
е - e  
у - y  
и - u  
о - o  
р - p  
а - a  
к - k  
х - x  
с - c  
Е - E  
Т - T  
О - O  
Р - P  
А - A  
Н - H  
К - K  
Х - X  
С - C  
В - B  
М - M  

В обсуждении: https://www.sql.ru/forum/770950/russkie-i-angliyskie-bukvy-odinakovogo-nachertaniya  
Приводятся 15 правил для замены символов.  
У - Y  
К - K  
Е - E  
Н - H  
Х - X  
В - B  
А - A  
п - n  
Р - P  
О - O  
С - C  
М - M  
Т - T  
З - 3  
О - O  

В таком виде с ними не очень удобно работать, правила для букв не упорядочены в алфавитном порядке и идут в разнобой. Сложно даже сказать какие из правил дублируют друг друга, а какие — различаются. Перепишем правила упорядочив их в алфавитном порядке и дополнив отсутствующими буквами.  

Нижний регистр:  
а - a  
б  
в  
г  
д  
е - e  
ё  
ж  
з  
и - u | неочевидная замена, но начертание действительное похоже  
й  
к - k | не очень похожи, но допустимо  
л  
м  
н  
о - o  
п  
р - p  
с - c  
т  
у - y  
ф  
х - x  
ц  
ч  
ш  
щ  
ъ  
ы  
ь  
э  
ю  
я  
9 правил  

Верхний регистр:  
А - A  
Б  
В - B  
Г  
Д  
Е - E  
Ё  
Ж  
З - 3 | не очень похожи, но допустимо  
И  
Й  
К - K  
Л  
М  
Н - H  
О - O  
П  
Р - P  
С - C  
Т - T  
У  
Ф  
Х - X  
Ц  
Ч  
Ш  
Щ  
Ъ  
Ы  
Ь  
Э  
Ю  
Я  
11 правил  

## Таблица преобразования

Получаем 20 правил соответствия. Из них 2 правила можно назвать "расширенными" или дополнительными, потому что символ-замена не очень похож на оригинальный символ и это сильно влияет на внешний вид текста.  

+-----+-----+-----+-----+---------------------------+  
| рус | анг | РУС | АНГ | комментарий               |  
+-----+-----+-----+-----+---------------------------+  
| а   | a   | А   | A   |                           |  
| б   |     | Б   |     |                           |  
| в   |     | В   | B   |                           |  
| г   |     | Г   |     |                           |  
| д   |     | Д   |     |                           |  
| е   | e   | Е   | E   |                           |  
| ё   |     | Ё   |     |                           |  
| ж   |     | Ж   |     |                           |  
| з   |     | З   | 3   |                           |  
| и   | u   | И   |     | не очень похожи           |  
| й   |     | Й   |     |                           |  
| к   |     | К   | K   | 'к' и 'k' не очень похожи |  
| л   |     | Л   |     |                           |  
| м   |     | М   |     |                           |  
| н   |     | Н   | H   |                           |  
| о   | o   | О   | O   |                           |  
| п   |     | П   |     |                           |  
| р   | p   | Р   | P   |                           |  
| с   | c   | С   | C   |                           |  
| т   |     | Т   | T   |                           |  
| у   | y   | У   |     |                           |  
| ф   |     | Ф   |     |                           |  
| х   | x   | Х   | X   |                           |  
| ц   |     | Ц   |     |                           |  
| ч   |     | Ч   |     |                           |  
| ш   |     | Ш   |     |                           |  
| щ   |     | Щ   |     |                           |  
| ъ   |     | Ъ   |     |                           |  
| ы   |     | Ы   |     |                           |  
| ь   |     | Ь   |     |                           |  
| э   |     | Э   |     |                           |  
| ю   |     | Ю   |     |                           |  
| я   |     | Я   |     |                           |  
+-----+-----+-----+-----+---------------------------+  
| 33  | 9   | 33  | 11  | Итого 20 правил           |  
+-----+-----+-----+-----+---------------------------+  