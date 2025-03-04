﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Начался отопительный сезон, в городе начали включать отопление и у жителей
            возникают проблемы. Для решения этих проблем они идут в жэк. В жэке есть 3 окна:
            1. В первом окно помогает людям решить проблемы с отоплением (подключение и тд);
            2. Во втором окне решают проблемы с оплатой отопления;
            3. В третье окно идут все остальные.
            Необходимо создать класс жителя. У жителя есть: имя, номер паспорта (для                                                                         
            однозначной идентификации), проблема, темперамент. Проблема характеризуется
            номером и описанием. Темперамент характеризуется степенью скандальности от 0 до
            10 (10-скандалист, 0-паинька), умом(1-умный, 0-тупой).
            В каждое окно жители встают по очереди. Перед входом в жэк стоит сотрудница Зина,
            которая уточняет у жителей, какая у них проблема и по ключевым словам определяет
            их в нужное окно.
            Если житель скандалист (от 5 и выше), то он не будет обращать внимание на очередь
            и обгонит людей, которые впереди него (на сколько человек обгонять житель
            спрашивает у пользователя). Если человек тупой, то он встаёт не в то окно, даже
            несмотря на указание Зины (случайным образом). К Зине все выстраиваются по правилу стека.*/
            Citizen[] citizens = new Citizen[]{
                new Citizen("Эмиль", Problem.Оплата, 4, 1),
                new Citizen("Камиль", Problem.Отопление, 8, 1),
                new Citizen("Артур", Problem.Другое, 3, 1),
                new Citizen("Алексей", Problem.Другое, 5, 0),
                new Citizen("Милена", Problem.Отопление, 2, 1),
                new Citizen("Азат", Problem.Оплата, 7, 0),
                new Citizen("Александр", Problem.Отопление, 6, 1),
                new Citizen("Екатерина", Problem.Отопление, 4, 1),
                new Citizen("Сергей", Problem.Отопление, 7, 1),
                new Citizen("Алина", Problem.Оплата, 3, 0),
                new Citizen("Николай", Problem.Оплата, 5, 1),
                new Citizen("Эльза", Problem.Отопление, 8, 1),
                new Citizen("Михаил", Problem.Оплата, 2, 0),
                new Citizen("Юлия", Problem.Оплата, 1, 1),
                new Citizen("Артем", Problem.Отопление, 9, 0),
                new Citizen("Виктория", Problem.Оплата, 3, 1),
                new Citizen("Игорь", Problem.Оплата, 6, 0),
                new Citizen("Полина", Problem.Другое, 4, 1),
                new Citizen("Виктор", Problem.Другое, 10, 0),
                new Citizen("Олеся", Problem.Отопление, 2, 1),
                new Citizen("Акакий", Problem.Отопление, 7, 1),
                new Citizen("Наталья", Problem.Оплата, 5, 1),
                new Citizen("Максим", Problem.Оплата, 8, 0),
                new Citizen("Каролина", Problem.Другое, 3, 1),
                new Citizen("Роман", Problem.Другое, 10, 1),
                new Citizen("Камила", Problem.Оплата, 1, 0),
                new Citizen("Степан", Problem.Отопление, 9, 1),
                new Citizen("Дарья", Problem.Отопление, 4, 1),
                new Citizen("Валентин", Problem.Другое, 7, 0)};
            QueueManager Zina = new QueueManager();
            foreach (Citizen citizen in citizens)
            {
                Zina.AddCitizenToQueue(citizen);
            }
            Zina.ProcessQueue();
            Zina.PrintQueues();
        }
    }
}
