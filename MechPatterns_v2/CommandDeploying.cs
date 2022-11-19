using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    class MechComplexityDeploying
    {
        MachineFactory machineFactory = new();
        ControlService controlService = new();
        decimal MechArmoreDeploy(Command command)
        {
            controlService.SetCommand(command);
            controlService.Deploy();
            return machineFactory.Armore;
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
        public decimal ArmoreDeploy(decimal component) => MechArmoreDeploy(new ArmoreDeploy(machineFactory, component));
        public decimal WeaponDeploy(decimal component) => MechWeaponDeploy(new WeaponDeploy(machineFactory, component));
        public decimal EngineDeploy(decimal component) => MechEngineDeploy(new EngineDeploy(machineFactory, component));
        public decimal SystemDeploy(decimal component) => MechSystemDeploy(new SystemDeploy(machineFactory, component));
    }
}
