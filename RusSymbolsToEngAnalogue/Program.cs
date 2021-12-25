using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



namespace RusSymbolsToEngAnalogue {
    class Program {
        private static readonly bool _highLevelOfSimilarity = true;

        private static readonly Dictionary<char, char> _charMap = new Dictionary<char, char> {
            { 'а', 'a' }, { 'А', 'A'},
            { 'В', 'B'},
            { 'е', 'e'}, { 'Е', 'E'},
            { 'З', '3'},
            { 'К', 'K'},
            { 'Н', 'H'},
            { 'о', 'о'}, { 'О', 'O'},
            { 'р', 'p'}, { 'Р', 'P'},
            { 'с', 'c'}, { 'С', 'C'},
            { 'Т', 'T'},
            { 'у', 'y'},
            { 'х', 'x'}, {'Х', 'X'}
        };

        private static readonly Dictionary<char, char> _extendedCharMap = new Dictionary<char, char> {
            { 'и', 'u'},
            { 'к', 'k'},
        };

        private static void Main(string[] args) {
            var charMap = _charMap;
            if (!_highLevelOfSimilarity) {
                charMap = Merge(_charMap, _extendedCharMap);
            }

            var (inputPath, outputPath) = ParseConsoleArgs(args);
            if (inputPath == null || outputPath == null) {
                ShowHelp();
                return;
            }

            var utf8noBom = new UTF8Encoding(false);

            var originalContent = File.ReadAllText(inputPath, utf8noBom);
            Console.WriteLine($"Файл {inputPath} считан, " +
                              $"количество символов: {originalContent.Length}.");

            (string transformContent, int replaceCount) = Transform(originalContent, charMap);
            Console.WriteLine($"Содержимое трансформировано, " +
                              $"количество произведённых замен: {replaceCount}.");

            File.WriteAllText(outputPath, transformContent, utf8noBom);
            Console.WriteLine($"Файл {outputPath} записан.");
        }

        private static Dictionary<char, char> Merge(Dictionary<char, char> map1,
                                                    Dictionary<char, char> map2)
        {
            var mapSizeMax = Math.Max(map1.Count, map2.Count);
            var map = new Dictionary<char, char>(mapSizeMax);
            foreach (var keyPair in map1) {
                map.Add(keyPair.Key, keyPair.Value);
            }
            foreach (var keyPair in map2) {
                map.TryAdd(keyPair.Key, keyPair.Value);
            }
            return map;
        }

        private static (string, string) ParseConsoleArgs(string[] args) {
            if (args.Length == 0) {
                return ("input.txt", "output.txt");
            }
            if (args.Length == 1) {
                return (null, null);
            }
            if (args.Length != 4) {
                return (null, null);
            }
            if (args[0].ToLower() != "--input" || args[2].ToLower() != "--output") {
                return (null, null);
            }
            return (args[1], args[3]);
        }

        private static void ShowHelp() {
            Console.WriteLine("Использование:");
            Console.WriteLine("RusSymbolsToEngAnalogue.exe [--input] [path1] [--output] [path2]");
            Console.WriteLine("Кодировка входного и выходного файла: UTF8 (без BOM)");
        }

        private static (string, int) Transform(string original, Dictionary<char, char> map) {
            var replaceCount = 0;
            var outputChars = new char[original.Length];
            for (var i = 0; i < original.Length; i++) {
                if (map.TryGetValue(original[i], out char analogueCh)) {
                    outputChars[i] = analogueCh;
                    replaceCount++;
                } else {
                    outputChars[i] = original[i];
                }
            }
            return (new string(outputChars), replaceCount);
        }
    }
}


