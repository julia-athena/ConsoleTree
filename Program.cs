using Tree;

int treeSize = 0;
if (args.Length > 0)
{
    treeSize = int.Parse(args[0]);
}
var tree = new ConsoleTree(treeSize);
Console.WriteLine(tree.AsStringOne());
Console.WriteLine(tree.AsStringTwo());

