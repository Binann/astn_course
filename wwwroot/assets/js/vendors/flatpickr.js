var flatpickrElements;
0 < document.querySelectorAll(".flatpickr").length &&
  (flatpickrElements = document.querySelectorAll(".flatpickr")).forEach(
    function (l) {
      flatpickr(l, { disableMobile: !0 });
    }
  );
