namespace XATF.GameLibrary.Renderables.BaseObjects
{
    public class MapTile : Renderable
    {
        protected override string FolderBase => "Tiles";

        public override void Update()
        {
            Position.Y += 5;
        }
    }
}