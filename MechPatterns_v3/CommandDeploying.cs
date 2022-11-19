using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class MechComplexityDeploying                                                                                               // класс вызывающий команды
    {
        MachineFactory machineFactory = new MachineFactory();                                                                   // объект класса команд
        ControlService controlService = new ControlService();                                                                   // объект вызывателя команд
        decimal MechArmoreDeploy(Command command)                                                                               // конкретная команда
        {
            controlService.SetCommand(command);                                                                                 // ставим задачу на выполнение
            controlService.Deploy();                                                                                            // вызываем команду
            return machineFactory.Armore;                                                                                       // получаем изменённый параметр
        }
        decimal MechWeaponDeploy(Command command)
        {
            controlService.SetCommand(command);
            controlService.Deploy();
            return machineFactory.Weapon;
        }
        decimal MechEngineDeploy(Command command)
        {
            controlService.SetCommand(command);
            controlService.Deploy();
            return machineFactory.Engine;
        }
        decimal MechSystemDeploy(Command command)
        {
            controlService.SetCommand(command);
            controlService.Deploy();
            return machineFactory.MechSystem;
        }
        public decimal ArmoreDeploy(decimal component) => MechArmoreDeploy(new ArmoreDeploy(machineFactory, component));        // получение параметра для изменения и вызов объекта команд для изменения
        public decimal WeaponDeploy(decimal component) => MechWeaponDeploy(new WeaponDeploy(machineFactory, component));
        public decimal EngineDeploy(decimal component) => MechEngineDeploy(new EngineDeploy(machineFactory, component));
        public decimal SystemDeploy(decimal component) => MechSystemDeploy(new SystemDeploy(machineFactory, component));
    }
}
