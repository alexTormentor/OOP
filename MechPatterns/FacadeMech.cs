using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechPatterns
{
    class MechFacade
    {
        Corpus corpus;
        Engine engine;
        Tooling tooling;
        public MechFacade(Corpus corpus, Engine engine, Tooling tooling) => (this.corpus, this.engine, this.tooling) = (corpus, engine, tooling);
        public void buildEngine()
        {
            engine.buildEngine();
        }
        public void buildCorpus()
        {
            corpus.buildCorpus();
        }
        public void buildTooling()
        {
            tooling.buildTooling();
        }
    }
}
