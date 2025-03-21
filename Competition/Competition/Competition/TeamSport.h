#pragma once
#include "Competition.h"

class TeamSport : public Competition {
protected:
    int teamSize;
public:
    TeamSport(std::string n, std::string loc, int size)
        : Competition(n, loc), teamSize(size) {}
    void printInfo() const override {
        std::cout << "Team Sport - Name: " << name << ", Location: " << location
            << ", Team Size: " << teamSize << std::endl;
    }
    void teamMeeting() {
        std::cout << name << " is having a team meeting." << std::endl;
    }
};