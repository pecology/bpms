window.onload = () => {
  document.querySelector("#detail-add-button").onclick = () => {
    const numOfDetails = document.querySelectorAll("#detail-table > tbody > tr").length;
    const addDetailIndex = numOfDetails;
    const addDetailHtmlString =
      `     <tr>
            <td>${addDetailIndex + 1}</td>
            <td>
              <input type="text" class="hour-text" name="details[${addDetailIndex}].startHour" value="9" />時
              <input type="text" class="minute-text" name="details[${addDetailIndex}].startMinute" value="00" />分～
              <input type="text" class="hour-text" name="details[${addDetailIndex}].endHour" value="18" />時
              <input type="text" class="minute-text" name="details[${addDetailIndex}].endMinute" value="00" />分
            </td>
            <td><textarea type="text" name="details[${addDetailIndex}].description"></textarea></td>
            <td><button>削除</button></td>
          </tr>`;

    const detailTbody = document.querySelector("#detail-table > tbody");
    detailTbody.insertAdjacentHTML('beforeend', addDetailHtmlString);
  }
}