using UnityEngine;
using Object = UnityEngine.Object;

namespace Builder
{
    public class MobBuilder
    {
        private Mob _prefab;
        private Skin _skinPrefab;
        private string _mobName;
        private UnitStats _stats;

        public MobBuilder WithRootPrefab(Mob prefab)
        {
            _prefab = prefab;
            return this;
        }

        public MobBuilder WithSkin(Skin skin)
        {
            _skinPrefab = skin;
            return this;
        }

        public MobBuilder WithName(string mobName)
        {
            _mobName = mobName;
            return this;
        }
        
        public MobBuilder WithStats(UnitStats stats)
        {
            _stats = stats;
            return this;
        }
        
        
        public Mob Build(Transform container = null)
        {
            var createdMob = Object.Instantiate(_prefab, container);
            var createdSkin = Object.Instantiate(_skinPrefab);
            createdMob.SetSkin(createdSkin);
            createdMob.SetName(_mobName);
            createdMob.SetStats(_stats);
            return createdMob;
        }

        public MobBuilder Reset()
        {
            _prefab = null;
            _skinPrefab = null;
            _mobName = null;
            _stats = null;

            return this;
        }
    }
}