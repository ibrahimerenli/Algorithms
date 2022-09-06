using System;

class BinarySearchTree {

	public class Node {
		public int key;
		public Node left, right;

		public Node(int item)
		{
			key = item;
			left = right = null;
		}
	}

	Node root;

	BinarySearchTree() { root = null; }

	BinarySearchTree(int value) { root = new Node(value); }

	void insert(int key) { root = insertRec(root, key); }

	Node insertRec(Node root, int key)
	{

		if (root == null) {
			root = new Node(key);
			return root;
		}

		if (key < root.key)
			root.left = insertRec(root.left, key);
		else if (key > root.key)
			root.right = insertRec(root.right, key);

		return root;
	}

	void inorder() { inorderRec(root); }

	void inorderRec(Node root)
	{
		if (root != null) {
			inorderRec(root.left);
			Console.WriteLine(root.key);
			inorderRec(root.right);
		}
    public void inorder() {
    Node temp = root;
    Stack<Node> stack = new Stack<Node>();
    while (temp != null || stack.Count!=0) {
      if (temp != null) {
        stack.Push(temp);
        temp = temp.left;
      } else {
        temp = stack.Pop();
        Console.Write(temp.val + " ");
        temp = temp.right;
      }
    }
  }
	}

	public static void Main(String[] args)
	{
		BinarySearchTree tree = new BinarySearchTree();

		/* Let us create following BST
			50
		/	 \
		30	 70
		/ \ / \
	20 40 60 80 */
		tree.insert(50);
		tree.insert(30);
		tree.insert(20);
		tree.insert(40);
		tree.insert(70);
		tree.insert(60);
		tree.insert(80);

		tree.inorder();
	}
  
}
