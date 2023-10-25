"""
# Function that finds out if a number is prime or not
"""

def prime(n):
    """
    Check if a given number is prime or not.

    Args:
        n (int): The number to be checked.

    Returns:
        bool: True if the number is prime, False otherwise.
    """
    if n <= 1:  # 1 is not a prime number
        return False
    for i in range(2, int(n ** 0.5) + 1):  # check divisibility from 2 to sqrt(n)
        if n % i == 0:  # if n is divisible by i, it's not a prime number
            return False
    return True  # if n is not divisible by any number from 2 to sqrt(n), it's a prime number


print (prime(4))
