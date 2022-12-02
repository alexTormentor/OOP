using MechSOLID;
using MechSOLID_D;
using MechSOLID_I;
using MechSOLID_L;
using MechSOLID_O;
using System;

namespace MechSOLID_Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Angar store = new Angar( new MechConsole(), new SMechSystem(),
                new SMechCreator(), new MechBuilder());
            store.Process();

            Engine[] engine = new Engine[] { new Corpus(), new MechCoreShell() };

            CoreDeploy core = new CoreDeploy("Ядро Аргус");
            core.CreateCore(engine);
            Personel emp = new Personel(1);
            Pilot pilot = new Pilot();
            MechAI mechai = new MechAI();
            AI ai = new AI();
            MechSystem system = new MechSystem();
            pilot.GetStatus(system);
            pilot.Message(system);
            pilot.Connect(system);
            pilot.LandscapeAnalyze(system);
            ai.UpdateStatus(mechai);

            Service service = new Service(new Servitor());
            service.Response();
            service.Adutante = new Center();
            service.Response();
        }
    }
}
