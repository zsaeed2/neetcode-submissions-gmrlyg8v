public class Node {
    int key;
    int value;
    Node prev;
    Node next;

    public Node(int key, int value) {
        this.prev = null;
        this.next = null;
        this.key = key;
        this.value = value;
    }
}

class LRUCache {
    private int capacity;
    private Map<Integer, Node> cache;
    private Node first;
    private Node last;

    public LRUCache(int capacity) {
        this.cache = new HashMap<>();
        this.capacity = capacity;
        this.first = new Node(-1, -1);
        this.last = new Node(-1, -1);
        this.first.next = this.last;
        this.last.prev = this.first;
    }

    public void remove(Node node) {
        Node prev = node.prev;
        Node next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    public void add(Node node) {
        Node prev = this.last.prev;
        prev.next = node;
        node.prev = prev;
        node.next = this.last;
        this.last.prev = node;
    }
    
    public int get(int key) {

        if (!cache.containsKey(key)) {
            return -1;
        }

        Node curr = cache.get(key);
        this.remove(curr);
        this.add(curr);
        return curr.value;
    }
    
    public void put(int key, int value) {
        if (cache.containsKey(key)) {
            remove(cache.get(key));
        }
        Node newNode = new Node(key, value);
        cache.put(key, newNode);
        this.add(newNode);

        if (cache.size() > this.capacity) {
            Node lru = this.first.next;
            this.remove(lru);
            cache.remove(lru.key);
        }
    }
}

