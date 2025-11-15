#include <iostream>
#include <string>
#include <limits>

using namespace std;


struct Node {
    string address;    // адрес
    int residents;     // брой жители
    Node* next;        // следващ елемент

    Node(const string& a, int r) : address(a), residents(r), next(nullptr) {}
};


Node* createList(int count);
void decrementResident(Node* head, const string& address);
void printList(Node* head);
void deleteList(Node*& head);

// Главна Функция
int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int count;
    cout << "Enter number of addresses: ";

    while (!(cin >> count) || count < 1) {
        cout << "Please enter positive integer: ";
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    // 1? Създаване на списъка
    Node* head = createList(count);

    // 2? Извеждане на първоначалния списък
    cout << "\n=== INITIAL LIST ===\n";
    printList(head);

    // 3? Намаляване на жителите по даден адрес
    cout << "\nEnter address to decrement residents: ";
    string addr;
    getline(cin, addr);

    decrementResident(head, addr);

    // 4? Извеждане на списъка след промяната
    cout << "\n=== LIST AFTER CHANGE ===\n";
    printList(head);

    // 5? Изтриване на целия списък
    deleteList(head);

    return 0;
}

// Функция за създаване на списък с адреси
Node* createList(int count) {
    Node* head = nullptr;
    Node* last = nullptr;

    for (int i = 0; i < count; ++i) {

        cout << "Address " << (i + 1) << ": ";
        string address;
        getline(cin, address);

        cout << "Number of residents: ";
        int res;
        while (!(cin >> res) || res < 0) {
            cout << "Enter non-negative number: ";
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
        }
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        Node* node = new Node(address, res);

        if (!head) {
            head = node;
        }
        else {
            last->next = node;
        }

        last = node;
    }

    return head;
}

//Функция за намаляване на жител от адрес
void decrementResident(Node* head, const string& address) {
    Node* curr = head;

    while (curr) {
        if (curr->address == address) {

            if (curr->residents > 0)
                curr->residents -= 1;

            cout << "\nResidents at \"" << address
                << "\" decreased by 1.\n";

            return;
        }
        curr = curr->next;
    }

    cout << "\nAddress not found.\n";
}

//Функция за извеждане на списъка
void printList(Node* head) {
    Node* curr = head;

    while (curr) {
        cout << "Address: " << curr->address
            << " | Residents: " << curr->residents << "\n";
        curr = curr->next;
    }
}

//Функция за изтриване на адресите(списъка)
void deleteList(Node*& head) {
    while (head) {
        Node* temp = head;
        head = head->next;
        delete temp;
    }
}
