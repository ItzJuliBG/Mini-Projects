#pragma once
#include "IndividualSport.h"

class Tennis : public IndividualSport {
protected:
    int setsWon;
public:
    Tennis(std::string n, std::string loc, std::string equip, int sets)
        : IndividualSport(n, loc, equip), setsWon(sets) {}
    void printInfo() const override {
        std::cout << "Tennis - Name: " << name << ", Location: " << location
            << ", Equipment: " << equipment << ", Sets Won: " << setsWon << std::endl;
    }
    void winSet() {
        std::cout << name << " has won a set!" << std::endl;
    }
};