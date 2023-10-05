import math

def closest_point(list, x, y):
    """Find the closest point to a given point in a list of points the
    distance is calculated using the euclidean distance formula

    Args:
        list (_list_): _list of tuple_
        x (_float_): _x coordinate in float or integer_
        y (_float_): _y coordinate in float or integer_

    Returns:
        _tuple_: _(x,y) coordinates in a 2D frame of the closest point_
    """
    # check if the input is valid

    if (type(list) != list) or (type(x) != int and type(x) != float) or (type(y) != int and type(y) != float):
        print("Please provide  list with tuples of (x,y) and the values for x and y as floats or numbers")
    else:
        # create a dictionary with the distances from the given point to all the points in the list
        distances = {}
        for point in list:
            # loop through the list and calculate the distance from the given point to all the points in the list
            x1, y1 = point
            distance = math.sqrt((x - x1)**2 + (y - y1)**2)
            # calculate the distance and add it to the dictionary using the euclidean distance formula sqrt((x-x1)^2 + (y-y1)^2)
            distances[point] = distance
        if (len(distances) == 0):
            print("There are no closest points to the given point")
            return None
        # return the point with the minimum distance
        closest_point = min(distances, key=distances.get)
        # print the point with the minimum distance
        return closest_point


# driver code
if __name__ == "__main__":
    # set the list of points
    # set the point to which we want to find the closest point x and y
    # print the closest point
    list = [(1, 2), (3, 4), (5, 6), (7, 8), (9, 10), (2, 3),
            (-1, 3), (4, 5), (7, 9), (3, 5), (9, 0), (-4, -5)]
    x = -3
    y = -4
    print(closest_point(list, x, y))
