#pragma once
#include "TeamSport.h"

class Football : public TeamSport {
protected:
    int goalsScored;
public:
    Football(std::string n, std::string loc, int size, int goals)
        : TeamSport(n, loc, size), goalsScored(goals) {}
    void printInfo() const override {
        std::cout << "Football - Name: " << name << ", Location: " << location
            << ", Team Size: " << teamSize << ", Goals Scored: " << goalsScored << std::endl;
    }
    void scoreGoal() {
        std::cout << name << " has scored a goal!" << std::endl;
    }
};