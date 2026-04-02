public class Node {
    public int key;
    public int value;
    public Node next;
    public Node prev;

    public Node(int key, int value) {
        this.key = key;
        this.value = value;
        this.prev = null;
        this.next = null;
    }
}

public class LRUCache {
    private int capacity;
    private Dictionary<int, Node> cache;
    private Node first;
    private Node last;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.cache = new Dictionary<int, Node>();
        this.first = new Node(-1, -1);
        this.last = new Node(-1, -1);
        first.next = last;
        last.prev = first;
    }

    private void remove(Node node) {
        Node prev = node.prev;
        Node next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    private void add(Node node) {
        Node prev = last.prev;
        prev.next = node;
        last.prev = node;
        node.next = last;
        node.prev = prev;
    }
    
    public int Get(int key) {
        if (!this.cache.ContainsKey(key)) {
            return -1;
        }

        Node node = this.cache[key];
        this.remove(node);
        this.add(node);
        return node.value;
    }
    
    public void Put(int key, int value) {
        if (this.cache.ContainsKey(key)) {
            this.remove(cache[key]);
            this.cache.Remove(key);
        }

        Node newNode = new Node(key, value);
        this.cache[key] = newNode;
        this.add(newNode);

        if (this.cache.Count() > this.capacity) {
            Node lru = first.next;
            this.cache.Remove(lru.key);
            this.remove(lru);
        }   
    }
}
