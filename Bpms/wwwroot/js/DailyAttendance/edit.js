window.onload = () => {
  document.querySelector("#detail-add-button").onclick = () => {
    const lastTr = document.querySelector("#detail-table > tbody > tr:nth-last-child(1)");

    const lastDetailNo = lastTr.querySelector(".detail-no").textContent;
    const addDetailNo = parseInt(lastDetailNo) + 1;

    const lastDetailEndHour = lastTr.querySelector(".end-hour-text").value;
    const addDetailStartHour = lastDetailEndHour;

    const lastDetailEndMinute = lastTr.querySelector(".end-minute-text").value;
    const addDetailStartMinute = lastDetailEndMinute;

    const addDetailHtmlString = 
      `
          <tr>
            <td class="detail-no">${addDetailNo}</td>
            <td>
              <input type="text" class="start-hour-text" value="${addDetailStartHour}" />時
              <input type="text" class="start-minute-text" value="${addDetailStartMinute}" />分～
              <input type="text" class="end-hour-text" value="" />時
              <input type="text" class="end-minute-text" value="" />分
            </td>
            <td><textarea type="text" class="description"></textarea></td>
            <td><button class="detail-delete-button">削除</button></td>
          </tr>
      `;

    const detailTbody = document.querySelector("#detail-table > tbody");
    detailTbody.insertAdjacentHTML('beforeend', addDetailHtmlString);
  }

  document.addEventListener('click', e => {
    const target = e.target || e.srcElement;
    if (target.getAttribute("class") == 'detail-delete-button') {
      const parentTr = target.closest("tr");

      const laterTrList = getNextAll(parentTr);
      laterTrList.forEach(tr => {
        const noStr = tr.querySelector(".detail-no").textContent;
        const no = parseInt(noStr);
        tr.querySelector(".detail-no").textContent = no - 1;
      });

      parentTr.parentNode.removeChild(parentTr);
    }
  });

  document.querySelector("#post-button").onclick = () => {
    const detailTrs = document.querySelectorAll("#detail-table > tbody > tr");
    detailTrs.forEach((tr, i) => {
      const startHourText = tr.querySelector(".start-hour-text");
      startHourText.setAttribute("name", `details[${i}].startHour`);

      const startMinuteText = tr.querySelector(".start-minute-text");
      startMinuteText.setAttribute("name", `details[${i}].startMinute`);

      const endHourText = tr.querySelector(".end-hour-text");
      endHourText.setAttribute("name", `details[${i}].endHour`);

      const endMinuteText = tr.querySelector(".end-minute-text");
      endMinuteText.setAttribute("name", `details[${i}].endMinute`);

      const descriptionText = tr.querySelector(".description");
      descriptionText.setAttribute("name", `details[${i}].description`);
    });

    document.querySelector("#form").submit();
  }
}

const getNextAll = element => {
  const nextElements = [];
  let nextElement = element.nextElementSibling;
  while (nextElement) {
    nextElements.push(nextElement);
    nextElement = nextElement.nextElementSibling;
  }
  return nextElements;
}