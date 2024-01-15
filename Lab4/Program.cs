using Lab4;

List < Shape > shapes = new List<Shape>();
shapes.Add(new Rectangle());
shapes.Add(new Triangle());
shapes.Add(new Circle());
foreach (Shape item in shapes)
{
    item.Draw();
}