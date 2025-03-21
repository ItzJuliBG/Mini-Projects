#include <iostream>
#include <vector>
#include "Football.h"
#include "Tennis.h"
#include "Competition.h"

int main() {
    std::vector<Competition*> competitions;
    competitions.push_back(new Football("Champions League", "Madrid", 11, 3));
    competitions.push_back(new Football("World Cup", "Qatar", 11, 5));
    competitions.push_back(new Tennis("Wimbledon", "London", "Racket", 4));
    competitions.push_back(new Tennis("US Open", "New York", "Racket", 3));

    for (const Competition* comp : competitions) {
        comp->printInfo();
    }

    // Освобождаване на паметта
    for (Competition* comp : competitions) {
        delete comp;
    }

    return 0;
}
