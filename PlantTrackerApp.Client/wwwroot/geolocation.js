/**
 * Retrieves the current geographic location of the user.
 *
 * @returns {Promise<{latitude: number, longitude: number}>} 
 *   A promise that resolves with an object containing the latitude and longitude of the user's current position.
 *   The promise is rejected if geolocation is not supported or if there is an error retrieving the position.
 */
window.getLocation = async function () {
    return new Promise((resolve, reject) => {
        if (!navigator.geolocation) {
            reject("Geolocation not supported.");
        }
        navigator.geolocation.getCurrentPosition(
            (position) => {
                resolve({
                    latitude: position.coords.latitude,
                    longitude: position.coords.longitude
                });
            },
            (error) => {
                reject(error.message);
            }
        );
    });
};
