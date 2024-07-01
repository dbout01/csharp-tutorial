def manage_destinations():
    visited_places = set()

    def add_place(place):
        if place in visited_places:
            print(f"{place} has already been visited.")
        else:
            visited_places.add(place)
            print(f"New trip planned to {place}.")

    def remove_place(place):
        if place in visited_places:
            visited_places.remove(place)
            print(f"{place} removed from your travel list.")
        else:
            print(f"{place} was not in your travel list.")

    def list_places():
        print("Visited Places:")
        for place in visited_places:
            print(place)

    return add_place, remove_place, list_places

def main():
    add_new_place, remove_place, list_places = manage_destinations()
    # Using the functionality
    add_new_place("Paris")
    add_new_place("Tokyo")
    add_new_place("Paris")  # Should indicate already visited
    list_places()
    remove_place("Tokyo")
    list_places()

if __name__ == "__main__":
    main()
