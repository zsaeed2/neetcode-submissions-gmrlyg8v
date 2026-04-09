public class Node {
    public int key;
    public int val;
    public Node next;
    public Node prev;

    public Node(int key, int val) {
        this.key = key;
        this.val = val;
        this.next = null;
        this.prev = null;
    }
}

public class LRUCache {
    private int capacity;
    private Node left;
    private Node right;
    private Dictionary<int, Node> cache;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.cache = new Dictionary<int, Node>();
        this.left = new Node(-1, -1);
        this.right = new Node(-1, -1);
        this.left.next = this.right;
        this.right.prev = this.left;
    }
    
    public int Get(int key) {
        if (!cache.ContainsKey(key)) {
            return -1;
        }
        Node curr = cache[key];
        this.Remove(curr);
        this.Add(curr);
        return curr.val;
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key)) {
            this.Remove(cache[key]);
        }

        Node newNode = new Node(key, value);
        cache[key] = newNode;
        this.Add(newNode);

        if (cache.Count > capacity) {
            cache.Remove(left.next.key);
            this.Remove(left.next);
        }
    }

    private void Remove(Node node) {
        Node prev = node.prev;
        Node next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    private void Add(Node node) {
        Node last = this.right.prev;
        last.next = node;
        this.right.prev = node;
        node.next = this.right;
        node.prev = last;
    }
}
