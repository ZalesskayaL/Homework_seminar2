# # Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N]. 
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

# *Пример:*

# 5
#     1 2 3 4 5
#     3
#     -> 1

# n = int(input("Введите количество символов в массиве: "))
# numbers = []

# for i in range(1,n+1):
#     numbers.append(i)

# print(*numbers)

# x = int(input("Введите число, чтобы узнать, сколько раз оно встречается: "))
# temp = 0
# i = 0
# while i < n:
#     if(numbers[i] == x):
#         temp = temp + 1
#     i = i + 1

# print(temp)




# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. 
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

# *Пример:*

# 5
#     1 2 3 4 5
#     6
#     -> 5


# n = int(input("Введите количество символов в массиве: "))
# numbers = []

# for i in range(1,n+1):
#     numbers.append(i)

# print(*numbers)

# x = int(input("Введите число: "))
# i = 0
# if x < 1:
#     print("Самое ближайшее число = 1")
# elif x > n:
#     print(f"Самое ближайшее число = {n}")
# else:
#     while i < x:
#         if(numbers[i] == x):
#             print((f"Выбранное число {i+1} находится в массиве"))
#         i = i + 1
        




# *Задача 20: * В настольной игре Скрабл (Scrabble) каждая буква имеет определенную ценность. В случае с английским алфавитом очки распределяются так:
# A, E, I, O, U, L, N, S, T, R – 1 очко; D, G – 2 очка; B, C, M, P – 3 очка; F, H, V, W, Y – 4 очка; K – 5 очков; J, X – 8 очков; Q, Z – 10 очков. 
# А русские буквы оцениваются так: А, В, Е, И, Н, О, Р, С, Т – 1 очко; Д, К, Л, М, П, У – 2 очка; Б, Г, Ё, Ь, Я – 3 очка; Й, Ы – 4 очка; Ж, З, Х, Ц, Ч – 5 очков; 
# Ш, Э, Ю – 8 очков; Ф, Щ, Ъ – 10 очков. 
# Напишите программу, которая вычисляет стоимость введенного пользователем слова. Будем считать, что на вход подается только одно слово, 
# которое содержит либо только английские, либо только русские буквы.

# *Пример:*

# ноутбук
#     12

class_1 = ["A", "E", "I", "O", "U", "L", "N", "S", "T", "R", "А", "В", "Е", "И", "Н", "О", "Р", "С", "Т"]
class_2 = ["D", "G", "Д", "К", "Л", "М", "П", "У"]
class_3 = ["B", "C", "M", "P", "Б", "Г", "Ё", "Ь", "Я"]
class_4 = ["F", "H", "V", "W", "Y", "Й", "Ы"]
class_5 = ["K", "Ж", "З", "Х", "Ц", "Ч"]
class_8 = ["J", "X", "Ш", "Э", "Ю"]
class_10 = ["Q", "Z", "Ф", "Щ", "Ъ"]

word = list(input("Введите слово для подсчета очков: ").upper())
print(*word)

i = 0
j = 0
result = 0
while i < len(word):
    while j < len(class_1):
        if word[i] == class_1[j]:
            result = result + 1
        j = j + 1
    j = 0
    while j < len(class_2):
        if word[i] == class_2[j]:
            result = result + 2
        j = j + 1
    j = 0
    while j < len(class_3):
        if word[i] == class_3[j]:
            result = result + 3
        j = j + 1
    j = 0
    while j < len(class_4):
        if word[i] == class_4[j]:
            result = result + 4
        j = j + 1
    j = 0
    while j < len(class_5):
        if word[i] == class_5[j]:
            result = result + 5
        j = j + 1
    j = 0
    while j < len(class_8):
        if word[i] == class_8[j]:
            result = result + 8
        j = j + 1
    j = 0
    while j < len(class_10):
        if word[i] == class_10[j]:
            result = result + 10
        j = j + 1
    j = 0
    i = i + 1

print(f"Количество очков: {result}")