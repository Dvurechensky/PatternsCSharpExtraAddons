﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 03:39:52
 * Version: 1.0.4
 */

/*
 * ПОРОЖДАЮЩИЕ ПАТТЕРНЫ
 * 
 * Глава_8: Сиглтон, Одиночка (Singleton)
 * 
 * - гантирует, что у класса есть только один экземпляр, 
 *   и предоставляет глобальную точку доступа к нему
 */
class Singleton
{
    private Singleton()
    {
        Data = 28;
        MoreData = 90;
    }

    public int Data { get; set; }
    public int MoreData { get; set; }
   
    /// <summary>
    /// Отложенный синглтон (ленивый одиночка)
    /// </summary>
    static Lazy<Singleton> uniqueInstance = new Lazy<Singleton>(() => new Singleton());
    public static Singleton Instance => uniqueInstance.Value;
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(Singleton.Instance.Data);
    }
}