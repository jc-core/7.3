namespace Assignment7_3 {
    internal class SearchTree {

        private TreeNode? root;

        public bool Add(int value) {

            if (root == null) {
                root = new TreeNode(value);
                return true;
            }

            return AddBelow(root, value);

        }

        bool AddBelow(TreeNode node, int value) {

            if (value == node.Value)
                return false;

            if (value < node.Value) {

                if (node.Left == null) {
                    node.Left = new TreeNode(value);
                    return true;
                }

                return AddBelow(node.Left, value);

            }

            if (node.Right == null) {
                node.Right = new TreeNode(value);
                return true;
            }

            return AddBelow(node.Right, value);

        }

        public bool Search(int value) {

            return SearchFrom(root, value);

        }

        bool SearchFrom(TreeNode? node, int value) {

            if (node == null)
                return false;

            if (value == node.Value)
                return true;

            if (value < node.Value)
                return SearchFrom(node.Left, value);

            return SearchFrom(node.Right, value);

        }

        public List<int> InOrder() {

            List<int> values = new();
            WalkInOrder(root, values);

            return values;

        }

        void WalkInOrder(TreeNode? node, List<int> values) {

            if (node == null)
                return;

            WalkInOrder(node.Left, values);
            values.Add(node.Value);
            WalkInOrder(node.Right, values);

        }

        public List<int> PreOrder() {

            List<int> values = new();
            WalkPreOrder(root, values);

            return values;

        }

        void WalkPreOrder(TreeNode? node, List<int> values) {

            if (node == null)
                return;

            values.Add(node.Value);
            WalkPreOrder(node.Left, values);
            WalkPreOrder(node.Right, values);

        }

        public List<int> PostOrder() {

            List<int> values = new();
            WalkPostOrder(root, values);

            return values;

        }

        void WalkPostOrder(TreeNode? node, List<int> values) {

            if (node == null)
                return;

            WalkPostOrder(node.Left, values);
            WalkPostOrder(node.Right, values);
            values.Add(node.Value);

        }
    }
}
