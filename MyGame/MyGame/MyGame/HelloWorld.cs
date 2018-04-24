using System.Diagnostics;
using System.Threading.Tasks;
using Urho;
using Urho.Actions;
using Urho.Gui;
using Urho.Resources;
using Urho.Shapes;

namespace MyGame
{
    public class HelloWorld : Application
    {
        public HelloWorld(ApplicationOptions options = null) : base(options) { }

        Scene _scene;
        ResourceCache _cache;

        protected override async void Start()
        {
            base.Start();

            _scene = new Scene();
            _scene.CreateComponent<Octree>();

            SetupCameraAndLighting(_scene);

            //CreateText();

            //CreatePyramid(_scene);
            //CreateBox(_scene);

            CreateBackground(_scene);

            //UI.UIMouseClick += args => {
            //    Debug.WriteLine("button pressed");
            //};
        }

        private void CreateText()
        {
            // Create Text Element
            Text text = new Text()
            {
                Value = "Hello World!",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            text.SetColor(Color.Cyan);
            text.SetFont(font: ResourceCache.GetFont("Fonts/Anonymous Pro.ttf"), size: 30);
            // Add to UI Root
            UI.Root.AddChild(text);
        }

        void SetupCameraAndLighting(Scene scene)
        {
            // Set up light
            Node light = scene.CreateChild(name: "light");
            light.CreateComponent<Light>();

            // Set up camera
            Node cameraNode = scene.CreateChild(name: "camera");
            Camera camera = cameraNode.CreateComponent<Camera>();
            cameraNode.Position = new Vector3(0, 0, 0);

            Renderer.SetViewport(0, new Viewport(scene, camera, null));
            Debug.WriteLine(cameraNode.Position);
        }

        private async Task CreatePyramid(Scene scene)
        {
            Node node = scene.CreateChild();
            node.Position = new Vector3(0, 0, 5);
            node.Rotation = new Quaternion(60, 0, 30);
            node.SetScale(1f);

            //Add Pyramid Model
            StaticModel modelObject = node.CreateComponent<StaticModel>();
            modelObject.Model = _cache.GetModel("Models/Pyramid.mdl");

            //Make it spin
            await node.RunActionsAsync(new RepeatForever(new RotateBy(duration: 1, deltaAngleX: 0, deltaAngleY: 90, deltaAngleZ: 0)));
        }

        void CreateBox(Scene scene)
        {
            Node node = scene.CreateChild();
            node.Position = new Vector3(0, 0, 5);
            node.SetScale(0.5f);
            node.Rotation = new Quaternion(60, 0, 30);

            // Create a Box Shape component:
            Box box = node.CreateComponent<Box>();
            box.Color = Color.Blue;
        }

        void CreateBackground(Scene scene)
        {
            Node node = scene.CreateChild();
            node.Position = new Vector3(0, 0, 0);
            node.Rotation = new Quaternion(30, 30, 0);
            node.SetScale(1f);

            //Add Pyramid Model
            StaticModel modelObject = node.CreateComponent<StaticModel>();
            modelObject.Model = ResourceCache.GetModel("Models/Pyramid.mdl");
        }
    }
}
