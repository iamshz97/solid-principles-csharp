using ISPWith.Interfaces;
using ISPWith.Models;

IManage manager = new Manager();
manager.Manage();

IWork worker = new Worker();
worker.StartWork();
worker.StopWork();

IEat eater = new Worker();
eater.StartEat();
eater.StopEat();