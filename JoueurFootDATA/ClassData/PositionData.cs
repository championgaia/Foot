
using System.Collections.Generic;

namespace JoueurFootDATA
{
    #region PositionData
    internal class PositionData
    {
        public int Id { get; set; }
        public string PositionNom { get; set; }
    }
    #endregion
    #region PositionDatas : liste des Position
    internal class PositionDatas
    {
        public List<PositionData> ListePosition { get; set; }
        private FootContexte context = new FootContexte();
        public PositionDatas(int idPosition)
        {
            ListePosition = new List<PositionData>();
            var liste = context.GetPosition(idPosition);
            foreach (var c in liste)
            {
                ListePosition.Add(new PositionData { Id = c.Id, PositionNom = c.PositionNom });
            }
        }
    }
    #endregion
}
