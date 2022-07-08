using UnityEngine;

namespace Def
{
    public class ProjectDef
    {
        public readonly string DataPath = Application.streamingAssetsPath;

        private static ProjectDef instance = null;
        public ProjectDef Instance()
        {
            if (instance == null)
            {
                instance = new ProjectDef();
            }
            return instance;
        }
    }
}