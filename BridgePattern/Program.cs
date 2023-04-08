using BridgePattern.Library;

IRenderer renderer = new RasterRenderer();
renderer.Render(new Circle("red", 5));

renderer = new VectorRenderer();
renderer.Render(new Square("green", 15));


