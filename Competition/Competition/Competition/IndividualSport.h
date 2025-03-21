#pragma once
#include "Competition.h"

class IndividualSport : public Competition {
protected:
    std::string equipment;
public:
    IndividualSport(std::string n, std::string loc, std::string equip)
        : Competition(n, loc), equipment(equip) {}
    void printInfo() const override {
        std::cout << "Individual Sport - Name: " << name << ", Location: " << location
            << ", Equipment: " << equipment << std::endl;
    }
    void prepareEquipment() {
        std::cout << name << " is preparing " << equipment << "." << std::endl;
    }
};
