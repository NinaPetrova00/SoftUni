const subscribers = {};

// similar to addEventListener
exports.subscribe = (eventType, callback) => {
    if (!subscribers[eventType]) {
        subscribers[eventType] = [];
    }

    subscribers[eventType].push(callback);

    return () => {
        subscribers[eventType] = subscribers[eventType].filter(x => x != callback);
    }
};

// similar to emit,trigger
exports.publish = (eventType, ...params) => {
    // first way
    subscribers[eventType].forEach(x => x(...params));

    // second way
    subscribers[eventType].forEach(x => x.apply(null, params));
};