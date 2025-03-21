#pragma once
#include <iostream>
#include <string>

class Competition {
protected:
    std::string name;
    std::string location;
public:
    Competition(std::string n, std::string loc) : name(n), location(loc) {}
    virtual ~Competition() {}
    virtual void printInfo() const = 0;
};
