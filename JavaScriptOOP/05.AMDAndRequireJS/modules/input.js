define(function() {
  var people = [
    { id: 1, name: 'Pepa Ivanova', age: 27, avatarUrl: 'images/pepa.jpg' },
    { id: 2, name: 'Joro Kitaeca', age: 39, avatarUrl: 'images/kitaeca.gif' },
    { id: 3, name: 'Kuzman Trendafilov', age: 55, avatarUrl: 'images/kuzman.jpg' },
    { id: 4, name: 'Barack Obama', age: 52, avatarUrl: 'images/obama.jpg' },
    { id: 5, name: 'Ivo Repata', age: 31, avatarUrl: 'images/repata.jpg' }
  ];

  var getPeople = function() {
    return people;
  };

  return {
    getPeople: getPeople
  };
});