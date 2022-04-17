export const invalidPet = (petData) => {
    const requiredFields = [
        'name',
        'breed',
        'age',
        'weight',
        'image'
    ];

    return requiredFields.some(p => !petData[p]);
};