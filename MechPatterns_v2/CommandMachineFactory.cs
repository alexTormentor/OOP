using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns_v2
{
    enum Components
    {
        ArmoreMk, WeaponMk, EngineMk, SystemVer
    }
    class MachineFactory
    {
        public decimal Armore { get; private set; }
        public decimal Weapon { get; private set; }
        public decimal Engine { get; private set; }
        public decimal MechSystem { get; private set; }
        public void MechArmoreDeploy(Components components, decimal component) => Armore = components switch
        {
            Components.ArmoreMk => Armore + component,
            Components.WeaponMk => Weapon - component/Armore,
            Components.EngineMk => Engine + component/Armore,
            _ => throw new InvalidOperationException()
        };
        public void MechWeaponDeploy(Components components, decimal component) => Weapon = components switch
        {
            Components.WeaponMk => Weapon + component,
            Components.ArmoreMk => Armore - component / Weapon,
            Components.EngineMk => Engine - component / Weapon,
            _ => throw new InvalidOperationException()
        };
        public void MechEngineDeploy(Components components, decimal component) => Engine = components switch
        {
            Components.EngineMk => Engine + component,
            Components.WeaponMk => Weapon - component / Engine,
            Components.ArmoreMk => Armore + component / Engine,
            _ => throw new InvalidOperationException()
        };
        public void MechSystemDeploy(Components components, decimal component) => MechSystem = components switch
        {
            Components.SystemVer => MechSystem + component * (Armore * Weapon / Engine),
            _ => throw new InvalidOperationException()
        };
    }
}
